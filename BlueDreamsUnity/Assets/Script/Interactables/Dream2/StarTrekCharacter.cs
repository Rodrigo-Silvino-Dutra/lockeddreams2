
using UnityEngine;

public class StarTrekCharacter : MonoBehaviour, IInteractable
{
    public string name;
    [SerializeField] private Transform holdingObject;
    public void OnFocusEnter()
    {

    }
    public void OnFocusExit()
    {
        if(ProgressionDream2._instance.isholdingStarTrekCharacter)
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAASSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
    }
    public void OnInteract()
    {
        if (!ProgressionDream2._instance.isholdingStarTrekCharacter && !ProgressionDream2._instance.isHoldingCD && !ProgressionDream2._instance.starTrekPuzzleCompleted)
        {
            Debug.Log("Entrou na Interacao");
            ProgressionDream2._instance.isholdingStarTrekCharacter = true;
            gameObject.transform.position = holdingObject.position;
            gameObject.transform.SetParent(holdingObject, true);
        }
        else
        {
            ProgressionChart._instance.lastInteractable.Pop();
        }
    }
}
