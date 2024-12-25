
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Movement")]
    [Tooltip("Adjust to movement speed")]
    public float moveSpeed;
    public float drag;

    public float rotationSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        InputSystem();
        SpeedControl();
        rb.linearDamping = drag; // Linear damping düzeltildi
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void InputSystem()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }



private void PlayerMove()
{
    // Hareket yönü
    moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
    moveDirection = moveDirection.normalized;

    // Kuvvet uygula
    rb.AddForce(moveDirection * moveSpeed * 10f, ForceMode.Force);

    // Dönüşü sadece hareket yönüne göre yap
    if (moveDirection != Vector3.zero)
    {
        Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
        rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}


    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVel.x, rb.linearVelocity.y, limitedVel.z);
        }
    }
}
