using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPointCam : MonoBehaviour
{
    
    public PointRotateCam   rotateCam;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            rotateCam.StartRotation45();
            
        }
    }
        
    
}
