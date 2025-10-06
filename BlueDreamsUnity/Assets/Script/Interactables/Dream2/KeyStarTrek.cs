using UnityEngine;

public class KeyStarTrek : MonoBehaviour, IInteractable
{
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
    }

    public void OnInteract()
    {
        ProgressionChart._instance.dream1 = true;
        Destroy(gameObject);
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
