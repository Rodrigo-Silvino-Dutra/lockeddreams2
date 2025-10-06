using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotate : MonoBehaviour, IInteractable
{
    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    public int numberShown;

    private void Start()
    {
        coroutineAllowed = true;
        numberShown = 0;
    }

    public void OnInteract()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("RotateWheel");
        }
    }

    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f, 3f, 0f);
            yield return new WaitForSeconds(0.01f);
        }

        FMODUnity.RuntimeManager.PlayOneShot("event:/Padlock", transform.position);
        coroutineAllowed = true;

        numberShown += 1;

        if (numberShown > 9)
        {
            numberShown = 0;
        }

        Rotated(name, numberShown);
    }
    public void OnFocusEnter(){

    }
    public void OnFocusExit(){}
}
