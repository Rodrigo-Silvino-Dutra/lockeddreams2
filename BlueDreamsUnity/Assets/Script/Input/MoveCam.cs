
using UnityEngine;


public class MoveCam : MonoBehaviour
{
    private float mouseSensitivity = 50f;

    [SerializeField] private Transform player;
    private Vector2 mouseXY;
    private float xRot;

    void Start()
    {

    }
   
    void FixedUpdate()
    {
        mouseXY.x = InputManager._instance.xyCam.x;
        mouseXY.y = InputManager._instance.xyCam.y;

        mouseXY.x *= Time.fixedDeltaTime * mouseSensitivity;
        mouseXY.y *= Time.fixedDeltaTime * mouseSensitivity;

        xRot += mouseXY.y;
        xRot = Mathf.Clamp(xRot, -45f, 50f);
        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        player.Rotate(Vector3.up * mouseXY.x);
    }
}
