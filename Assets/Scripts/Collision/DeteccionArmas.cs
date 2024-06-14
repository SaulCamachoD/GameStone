using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionArmas : MonoBehaviour
{
    public BoxCollider blade;
    // Start is called before the first frame update
    void Start()
    {
        DesactivarCollidersArmas();
    }

    public void ActivarCollidersArmas()
    {
        if (blade != null)
        {
            blade.enabled = true;
        }
        
    }
    public void DesactivarCollidersArmas()
    {
        if (blade != null)
        {
            blade.enabled = false;
        }
    }
    
}
