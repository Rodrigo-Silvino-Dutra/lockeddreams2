using UnityEngine;

public class LavaLamp : MonoBehaviour, IInteractable
{
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
    }

    public void OnInteract()
    {
        ProgressionChart._instance.SawLight = true;
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
