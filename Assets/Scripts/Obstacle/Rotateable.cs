using System.Diagnostics;
using UnityEngine;

public class Rotateable : MonoBehaviour
{
    [SerializeField]private ObstacleSO obstacleSO;

    [SerializeField]private Vector3 rotationSpeed = new Vector3(0, 100, 0);

    private void Update() {
        
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

}
