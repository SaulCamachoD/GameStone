using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionArmas : MonoBehaviour
{
    public BoxCollider blade;

    private float congelarDuracion = 0.05f;
    // Start is called before the first frame update

    void Start()
    {
        DesactivarCollidersArmas();
    }

    public void ActivarCollidersArmas()
    {
        if (blade != null)
        {
            blade.enabled = true;
        }

        StartCoroutine(Lento());
    }

    public void DesactivarCollidersArmas()
    {
        if (blade != null)
        {
            blade.enabled = false;
        }
    }

    public IEnumerator Lento()
    {
        Time.timeScale = congelarDuracion;
        //Time.fixedDeltaTime = congelarDuracion * Time.deltaTime;
        yield return new WaitForSecondsRealtime(0.2f);
        Time.timeScale = 1;
    }
}
