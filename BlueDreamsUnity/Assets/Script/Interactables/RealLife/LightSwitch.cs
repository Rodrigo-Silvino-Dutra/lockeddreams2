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
        if (!active && ProgressionChart._instance.dream2 == true)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Switch", transform.position);
            light.SetActive(!light.activeSelf);
            active = true;
            ProgressionChart._instance.light++;
            Debug.Log(ProgressionChart._instance.light);
        }
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
