using UnityEngine;


public class UnlockDash : MonoBehaviour
{   
    public Movements movements;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            movements.UnlockDash();
            Destroy(gameObject);
        }
    }
}
