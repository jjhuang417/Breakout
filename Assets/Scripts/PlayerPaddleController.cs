using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddleController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMovement(InputValue inputValue)
    {
        rb.linearVelocity = inputValue.Get<Vector3>() * moveSpeed;        
    }
}
