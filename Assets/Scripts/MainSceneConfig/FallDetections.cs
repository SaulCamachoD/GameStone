using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetections : MonoBehaviour
{   
    public PlayerLoctions locations;
    public PointRotateCam rotateCam;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            locations.ReLocation();
            rotateCam.StartRotationOrigin();
        }
    }

}
