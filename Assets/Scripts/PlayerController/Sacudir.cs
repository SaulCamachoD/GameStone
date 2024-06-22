using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sacudir : MonoBehaviour
{
    public float pushForce = 5f; // Fuerza del empujón

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void PushBack(Vector3 attackDirection)
    {
        Vector3 pushDirection = -attackDirection.normalized; // Dirección opuesta al ataque
        rb.AddForce(pushDirection * pushForce, ForceMode.Impulse);
    }
}
