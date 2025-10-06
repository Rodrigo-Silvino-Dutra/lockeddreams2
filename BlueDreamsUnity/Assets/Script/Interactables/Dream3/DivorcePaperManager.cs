using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivorcePaperManager : MonoBehaviour, IInteractable
{
      public static bool divorceviewed;
      [SerializeField] GameObject divorcepaper;

    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        divorceviewed = true;
        divorcepaper.SetActive(false);
    }

    public void OnInteract()
    {
        divorcepaper.SetActive(true);
        
    }
    }





