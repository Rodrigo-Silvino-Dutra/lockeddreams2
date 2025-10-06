using UnityEngine;
using System.Collections.Generic;

public class PlayerInteractables : MonoBehaviour
{
    [SerializeField] private Camera myCam;
    [SerializeField] private float rayDistance = 3f;

    private IInteractable currentInteractable;
    
    private void Update()
    {
        CheckInteractables();
    }

    private void CheckInteractables()
    {
        Ray ray = new(myCam.transform.position, myCam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))//detecta se o raio bateu em algo
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();//pega o script do objeto observado

            if (interactable != currentInteractable)
            {
                InteractionUIManager._instance.TriggerCursor(true);
                currentInteractable = interactable;
                currentInteractable?.OnFocusEnter();
            }
        }
        else
        {
            currentInteractable = null;
        }
        if(currentInteractable == null)InteractionUIManager._instance.TriggerCursor(false);
    }
    public void InteractWithSubscribe() 
    {
        if (currentInteractable != null) ProgressionChart._instance.lastInteractable.Push(currentInteractable);
        currentInteractable?.OnInteract();
    }
    public void OutInteractWithSubscribe()
    {
        if (currentInteractable != null) Debug.Log("Existe e saindo da interacao");
        ProgressionChart._instance.lastInteractable.Peek()?.OnFocusExit();
        ProgressionChart._instance.lastInteractable.Pop();

    }
}