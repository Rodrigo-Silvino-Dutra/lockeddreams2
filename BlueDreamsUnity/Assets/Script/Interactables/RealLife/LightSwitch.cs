 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour, IInteractable
{
    [SerializeField] public GameObject light;
    bool active = false;
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInteract()
    {
        if (!active)
        {
            light.SetActive(!light.activeSelf);
            active = true;
            ProgressionChart._instance.light++;
            Debug.Log(ProgressionChart._instance.light);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Switch", transform.position);
        }
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
