using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour, IInteractable
{
    public static bool notebookOpened;
    [SerializeField] GameObject notebook;
    [SerializeField] GameObject code;
    [SerializeField] GameObject dvpaper;
    [SerializeField] GameObject player;
    [SerializeField] GameObject cam;
     public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        player.GetComponent<PlayerController>().enabled = true;
        cam.GetComponent<MoveCam>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        notebook.SetActive(false);
        code.SetActive(false);
    }

    public void OnInteract()
    {
        notebook.SetActive(true);
        notebookOpened = true;
        player.GetComponent<PlayerController>().enabled = false;
        cam.GetComponent<MoveCam>().enabled = false;
        if(puzzle3.puzzledone == true)
        {
            Cursor.lockState = CursorLockMode.None;
            code.SetActive(true);
        } 
        
    }

}
