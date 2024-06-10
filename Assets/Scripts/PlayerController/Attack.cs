using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float health = 100f;
    void Start()
    {
        
    }
    
    public void Damage(float damage)
    {
        health -= damage;
    }

    public void ResetHealth()
    {
        health = 100f;
    }
}

