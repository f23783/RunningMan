using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public static CharacterStats instance;

    [SerializeField]private int maxHealth;
    public float health;
    public float walkSpeed;
    public float runSpeed;


    private void Awake() {
        instance = this;
    }

    private void Start() {
        health = maxHealth;
    }

    private void Update() {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }
}
