using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSacudida : MonoBehaviour
{
    public float shakeDuration = 0.3f; // Duración del sacudido
    public float shakeAmount = 0.7f; // Magnitud del sacudido

    private Vector3 originalPosition;
    private float shakeTimeRemaining;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }

    public void ShakeCam()
    {
        shakeTimeRemaining = shakeDuration;
    }

    private void Update()
    {
        if (shakeTimeRemaining > 0)
        {
            transform.localPosition = originalPosition + Random.insideUnitSphere * shakeAmount;
            shakeTimeRemaining -= Time.deltaTime;
        }
        else
        {
            transform.localPosition = originalPosition; // Restaurar la posición original
        }
    }
}
