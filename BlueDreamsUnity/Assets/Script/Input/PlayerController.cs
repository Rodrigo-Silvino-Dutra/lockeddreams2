using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundMask;

    private Vector3 velocity;
    private float speed = 2f;
    private float gravity = -9.81f;
    private float groundDistance = 0.4f;
    private bool IsGrounded;

    void FixedUpdate()
    {
        IsGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (IsGrounded && velocity.y < 0) velocity.y = -2f;

        Vector3 move = transform.right * InputManager._instance.xzPlayer.x + transform.forward * InputManager._instance.xzPlayer.y;
        if(ProgressionChart._instance.isInteracting == false
        )controller.Move(move * speed  *Time.fixedDeltaTime);
        
        

        velocity.y += gravity * Time.fixedDeltaTime;

        controller.Move(velocity * Time.fixedDeltaTime);
    }
    
}
