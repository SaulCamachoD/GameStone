using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPonitCamB : MonoBehaviour
{
    public PointRotateCam rotateCam;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            rotateCam.StartRotationOrigin();

        }
    }
}
