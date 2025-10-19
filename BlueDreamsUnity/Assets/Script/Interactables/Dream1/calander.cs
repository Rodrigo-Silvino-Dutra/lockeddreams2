using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class calander : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject plaer;
    [SerializeField] GameObject cam;
    [SerializeField] TextMeshProUGUI text;
    private Vector3 ogPosition;
    // Start is called before the first frame update
    void Start()
    {
        ogPosition = transform.position;
    }



    public void OnInteract() 
    {
        transform.position = cam.transform.position + cam.transform.forward;
        plaer.GetComponent<PlayerController>().enabled = false;
        cam.GetComponent<MoveCam>().enabled = false;

        ProgressionChart._instance.datacheck = true;
        text.text = "12: Final da champions.<br 13: Museu.<br 14: Luto pela guerra de 1812.";

        ProgressionChart._instance.datacheck = true;

    }

    public void OnFocusEnter() { }


    public void OnFocusExit()
    {
        transform.position = ogPosition;
        plaer.GetComponent<PlayerController>().enabled = true;
        cam.GetComponent<MoveCam>().enabled = true;
        text.text = " ";
    }
}
