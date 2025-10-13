using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public void EndDream2()
    {
        ProgressionDream2._instance.dream2Completed = true;
        ProgressionChart._instance.dream2 = true;
    }
    public void PlayStarTrekSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SpaceShip_Lauching", transform.position);
    }
}
