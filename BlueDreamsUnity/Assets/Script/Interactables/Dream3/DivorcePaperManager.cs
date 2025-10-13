using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivorcePaperManager : MonoBehaviour, IInteractable
{
      public static bool divorceviewed;
      [SerializeField] GameObject divorcepaper;
          [SerializeField] GameObject player;
    [SerializeField] GameObject cam;

    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        divorceviewed = true;
        divorcepaper.SetActive(false);
                player.GetComponent<PlayerController>().enabled = true;
        cam.GetComponent<MoveCam>().enabled = true;
    }

    public void OnInteract()
    {
        divorcepaper.SetActive(true);
        FMODUnity.RuntimeManager.PlayOneShot("event:/CatchPaper", transform.position);
                player.GetComponent<PlayerController>().enabled = true;
        cam.GetComponent<MoveCam>().enabled = true;
    }
    }





