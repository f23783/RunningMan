using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    public InputSC inputsSc;

    public InputAction movement, jump;


    private void Awake() {
        
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }

        inputsSc = new InputSC();

        inputsSc.ActionMap.Enable();

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start() {
        movement = inputsSc.FindAction("MovementAction");
        jump = inputsSc.FindAction("JumpAction");
    }

}
