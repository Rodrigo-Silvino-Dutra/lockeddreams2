using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    [SerializeField] private GameObject keyToTheDoor;
    public void DestroySelf()
    {
        Destroy(gameObject);
        keyToTheDoor.SetActive(true);
    }
}
