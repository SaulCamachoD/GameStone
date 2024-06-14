using UnityEngine;


public class CloseDoorBoss : MonoBehaviour
{   
    public BossDoor bossDoor;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            bossDoor.ActiveDoorEvent();
            Destroy(gameObject);
        }
    }
}
