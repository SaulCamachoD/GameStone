using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointCamC : MonoBehaviour
{
    public PointRotateCam rotateCam;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            rotateCam.StartRotation90();

        }
    }
}
