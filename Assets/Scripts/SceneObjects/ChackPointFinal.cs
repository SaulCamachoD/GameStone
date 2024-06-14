using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChackPointFinal : MonoBehaviour
{
    public HudManager hudManager;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gema")
        {
            hudManager.ActiveFinalMenu();
        }
    }
}
