using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointBoss : MonoBehaviour
{
    public PlayerLoctions locations;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            locations.CheckPointBoss(transform.position);
            locations.CurrentLocation(transform.position);
            locations.EventBoss(true);
            locations.isPlayerResetting = false;
        }
    }
}
