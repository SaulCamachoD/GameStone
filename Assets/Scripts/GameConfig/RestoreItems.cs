using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreItems : MonoBehaviour
{
    public SystemLife attack;
    void Start()
    {

    }
    

    public void ResetPlayerHeatlh()
    {
        attack.ResetHealth();
    }
}
