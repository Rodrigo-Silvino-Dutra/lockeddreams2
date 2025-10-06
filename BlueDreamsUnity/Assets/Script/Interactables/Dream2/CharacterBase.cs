using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform holdingObject;
    [SerializeField] private string BaseName;
    [SerializeField] private int index;

    public void OnFocusEnter(){}
    public void OnFocusExit(){}
    public void OnInteract()
    {
        Transform starTrekDoll = holdingObject.GetChild(0);
        if (ProgressionDream2._instance.isholdingStarTrekCharacter && starTrekDoll != null)
        {
            if (starTrekDoll.CompareTag(BaseName))
            {
                ProgressionDream2._instance.dollsPlaced[index] = true;
                ProgressionDream2._instance.ActiveGalileoPuzzle(ProgressionDream2._instance.dollsPlaced[index], index);
            }
            ProgressionDream2._instance.isholdingStarTrekCharacter = false;
            starTrekDoll.SetParent(holdingObject, false);
            starTrekDoll.position = gameObject.transform.position;
            starTrekDoll.SetParent(gameObject.transform, true);
            ProgressionDream2._instance.IsEveryThingInPlace();
        }
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
