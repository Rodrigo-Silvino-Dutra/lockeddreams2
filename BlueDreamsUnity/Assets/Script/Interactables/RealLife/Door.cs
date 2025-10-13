using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    Animator anim;
    [SerializeField] GameObject fadeout;
    IEnumerator OpenDoor(){
            anim.Play("open");
            yield return new WaitForSeconds(0.6f);
            fadeout.SetActive(true);


        }
    void Start(){
        anim = GetComponent<Animator>();
        
    }
    
    public void OnFocusEnter()
    {
        
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInteract()
    {
        if(ProgressionChart._instance.dream3 == true)
        {
            StartCoroutine(OpenDoor());

        }
        StopCoroutine(OpenDoor());
    }

}
