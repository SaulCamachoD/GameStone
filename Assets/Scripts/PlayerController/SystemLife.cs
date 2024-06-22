using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SystemLife : MonoBehaviour
{
    public float       health;
    public float       healtActual;
    public UnityEvent  evenMorir;
    void Start()
    {
        healtActual = health;
    }
    
    public void Damage(float damage)
    {
        healtActual -= damage;
        if (healtActual <= 0)
        {
            print("Muerto " + gameObject.name);
            evenMorir.Invoke();
        }
        
    }

    public void ResetHealth()
    {
        health = 100f;
    }
}

