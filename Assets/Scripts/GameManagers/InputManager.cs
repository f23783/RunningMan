using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public InputSC inputsSc;

    public InputAction movement;


    private void Awake() {
        inputsSc = new InputSC();

        inputsSc.ActionMap.Enable();
    }

    private void Start() {
        movement = inputsSc.FindAction("MovementAction");
    }

    public Vector3 GetMovementVectorNormalized()
    {
        Vector3 moveValue = movement.ReadValue<Vector3>();

        moveValue.y = 0f;
        
        return moveValue;
    }
}
