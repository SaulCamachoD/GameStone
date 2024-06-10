using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChackPoints : MonoBehaviour
{   
    public PlayerLoctions locations;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            locations.CurrentLocation(transform.position);
            locations.EventBoss(false);
        }
    }
}
