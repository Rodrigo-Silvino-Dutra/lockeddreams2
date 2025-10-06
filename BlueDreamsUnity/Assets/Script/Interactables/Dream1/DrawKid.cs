using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawKid : MonoBehaviour, IInteractable
{
    public static bool drawviewed;
    [SerializeField] GameObject draw;

    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        drawviewed = true;
        draw.SetActive(false);
    }

    public void OnInteract()
    {
        draw.SetActive(true);

    }
}

