using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ControlWeapon : MonoBehaviour
{
    //public PlayerVariables playerVariables;
    private int _currentIndex;
    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
            //Debug.Log("Disparaste");
          //  PlayerVariables.instance.currentWeapon?.Use(transform.forward);
            
        //}

        if (Input.GetKeyDown(KeyCode.Q))
        {
           PlayerVariables.instance.NextWeapon();
           
           
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
           PlayerVariables.instance.PrevWeapon();
           
        }
    }
}
