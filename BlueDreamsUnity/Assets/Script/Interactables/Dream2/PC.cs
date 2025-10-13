using UnityEngine;

public class PC : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform holdingObject;
    [SerializeField] private GameObject screen;
    [SerializeField] private GameObject Data;
    private string pc = "Linux";

    public void OnFocusEnter()
    {
    }
    public void OnFocusExit()
    {
    }
    public void OnInteract()
    {
        Transform cd = holdingObject.GetChild(0);
        if (ProgressionDream2._instance.isHoldingCD && cd != null)
        {
            if (cd.CompareTag(pc))
            {
                Destroy(cd.gameObject);
                ProgressionDream2._instance.isHoldingCD = false;
                screen.SetActive(true);
                Data.SetActive(true);
                FMODUnity.RuntimeManager.PlayOneShot("event:/Old_PC_turnOn", transform.position);

            }
        }
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
