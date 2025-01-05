using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public static CharacterStats instance;

    [SerializeField]private int maxHealth;
    public float health;


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
}
