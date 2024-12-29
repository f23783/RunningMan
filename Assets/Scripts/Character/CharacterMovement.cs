using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Adjust to movement speed")]
    public float moveSpeed = 10f;
    public float drag = 5f;
    public float airDrag = 2f;
    public float rotationSpeed = 10f;

    [Header("Jump Settings")]
    public Transform groundCheck;
    public float groundCheckDistance = 0.3f;
    public LayerMask groundLayer;
    public float jumpForce = 5f;

    [Header("References")]
    public Transform orientation;

    private float horizontalInput;
    private float verticalInput;
    private bool jumpInput;
    private bool isGrounded;

    private Vector3 moveDirection;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        CheckGround();
        ApplyDrag();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        Jump();
        
    }

    private void CheckGround()
    {
        // Cast a ray downwards to check if the player is grounded
        
        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, groundCheckDistance, groundLayer);
    }

    private void ApplyDrag()
    {
        rb.linearDamping = drag; // Set Rigidbody drag to simulate air resistance
        if (jumpInput && isGrounded)
        {
            rb.linearDamping = airDrag;
        }
        else
        {
            rb.linearDamping = drag;
        }
    }

    public Vector3 GetMovementVectorNormalized()
    {
        Vector3 moveValue = InputManager.Instance.movement.ReadValue<Vector3>();

        moveValue.y = 0f;
        
        return moveValue;
    }

    private void MovePlayer()
    {
        moveDirection = GetMovementVectorNormalized();

        rb.AddForce(moveDirection * moveSpeed, ForceMode.Force);

        // Rotate towards movement direction
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }

    private void Jump()
    {
        if (InputManager.Instance.jump.IsPressed() && isGrounded)
        {
             rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
       
    }

    private void SpeedControl()
    {
        // Cap the player's speed
        Vector3 flatVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (flatVelocity.magnitude > moveSpeed)
        {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVelocity.x, rb.linearVelocity.y, limitedVelocity.z);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Visualize the ground check in the editor
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * groundCheckDistance);
        }
    }
}
