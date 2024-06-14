using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLightStatue : MonoBehaviour
{
    // Referencia a la primera luz spot
    public Light spotLight1;

    // Referencia a la segunda luz spot
    public Light spotLight2;

    // Intensidad inicial y final
    public float initialIntensity = 5f;
    public float finalIntensity = 20f;

    // Número de veces que titilarán las luces
    public int blinkCount = 5;

    // Duración del titileo
    public float blinkDuration = 0.5f;

    void Start()
    {
        // Asegúrate de que las luces tengan la intensidad inicial al comenzar
        if (spotLight1 != null)
            spotLight1.intensity = initialIntensity;
        if (spotLight2 != null)
            spotLight2.intensity = initialIntensity;
    }

    void OnTriggerEnter(Collider other)
    {
        // Cuando el collider se activa, comienza la Coroutine
        StartCoroutine(BlinkAndIncreaseIntensity());
    }

    IEnumerator BlinkAndIncreaseIntensity()
    {
        for (int i = 0; i < blinkCount; i++)
        {
            // Apagar las luces
            if (spotLight1 != null)
                spotLight1.intensity = 0;
            if (spotLight2 != null)
                spotLight2.intensity = 0;
            yield return new WaitForSeconds(blinkDuration / 2);

            // Encender las luces
            if (spotLight1 != null)
                spotLight1.intensity = initialIntensity;
            if (spotLight2 != null)
                spotLight2.intensity = initialIntensity;
            yield return new WaitForSeconds(blinkDuration / 2);
        }

        // Aumentar la intensidad a la final
        if (spotLight1 != null)
            spotLight1.intensity = finalIntensity;
        if (spotLight2 != null)
            spotLight2.intensity = finalIntensity;
    }
}
