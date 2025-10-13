using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCollect : MonoBehaviour, IInteractable
{ 
    public static int booksremaining = 11;
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInteract()
    {
        if (NotebookManager.notebookOpened == true)
        {  
        booksremaining--;   
        Destroy(gameObject);
        Debug.Log("livros restantes:  " + booksremaining);
        ProgressionChart._instance.lastInteractable.Pop();
        FMODUnity.RuntimeManager.PlayOneShot("event:/CatchBook", transform.position);
        }
        ;
    }


}
