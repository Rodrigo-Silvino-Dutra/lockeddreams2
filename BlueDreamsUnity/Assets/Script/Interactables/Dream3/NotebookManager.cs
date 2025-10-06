using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour, IInteractable
{
    public static bool notebookOpened;
    [SerializeField] GameObject notebook;
    [SerializeField] GameObject code;
    [SerializeField] GameObject dvpaper;
     public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        notebook.SetActive(false);
        code.SetActive(false);
    }

    public void OnInteract()
    {
        notebook.SetActive(true);
        notebookOpened = true;
        if(puzzle3.puzzledone == true)
        {   
        code.SetActive(true);
        } 
        
    }

}
