using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Padlock : MonoBehaviour, IInteractable
{
    public GameObject player;
    public GameObject camera;
    Vector3 originPosition;
    private int[] result, correctCombination;
    private bool isOpened;
    public Animator anim;

    private void Start()
    {
        
        originPosition = transform.position;
        result = new int[]{0,0,0};
        correctCombination = new int[] {1,1,1};
        isOpened = false;
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "WheelOne":
                result[0] = number;
                break;

            case "WheelTwo":
                result[1] = number;
                break;

            case "WheelThree":
                result[2] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2] && !isOpened)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
            isOpened = true;
            OnFocusExit();
        }
    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }

    public void OnFocusEnter()
    {
        transform.LookAt(camera.transform.position);
    }
    public void OnInteract()
    {
        transform.position = camera.transform.position + camera.transform.forward * 0.2f;
        player.GetComponent<PlayerController>().enabled = false; 
        GetComponent<BoxCollider>().enabled = false;
    }

    public void OnFocusExit()
    {
        if (isOpened)
        {
            Destroy(gameObject);
            anim.Play("ChestOppened"); 
            player.GetComponent<PlayerController>().enabled = true;
            FMODUnity.RuntimeManager.PlayOneShot("event:/Chest_Open", transform.position);
        }
        else
        {
            transform.position = originPosition;
            player.GetComponent<PlayerController>().enabled = true; 
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}