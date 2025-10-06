using UnityEngine;

public class Disket : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform holdingObject;
    [SerializeField] private Transform Drawer;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(Drawer != null)gameObject.transform.SetParent(Drawer, true);
    }
    public void OnFocusEnter()
    {
    }
    public void OnFocusExit()
    {
        transform.SetParent(null);
        rb.isKinematic = false;
        ProgressionDream2._instance.isHoldingCD = false;
    }
    public void OnInteract()
    {
        if (!ProgressionDream2._instance.isholdingStarTrekCharacter && !ProgressionDream2._instance.isHoldingCD)
        {
            rb.isKinematic = true;
            ProgressionDream2._instance.isHoldingCD = true;
            gameObject.transform.position = holdingObject.position;
            gameObject.transform.SetParent(holdingObject, true);
        }
        else
        {
            ProgressionChart._instance.lastInteractable.Pop();
        }
    }
}
