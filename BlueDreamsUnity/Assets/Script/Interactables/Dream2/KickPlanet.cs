using UnityEngine;

public class KickPlanet : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform player;
    private float kickForce = 10f;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            rigidbody.AddForce((gameObject.transform.position - player.position) * kickForce, ForceMode.Force);
        }
    }
    public void OnFocusEnter()
    {
    
    }
    public void OnFocusExit()
    {
        
    }
    public void OnInteract()
    {
        rigidbody.AddForce((gameObject.transform.position - player.position).normalized * kickForce, ForceMode.Force);
        ProgressionChart._instance.lastInteractable.Pop();
    }
}
