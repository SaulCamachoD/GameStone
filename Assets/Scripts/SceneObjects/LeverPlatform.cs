using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPlatform : MonoBehaviour
{
    public MovablePlatform platform;

    public float rotationAngle = 45.0f;
    public float rotationSpeed = 2.0f;
    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private bool isRotatingToTarget = false;

    void Start()
    {
        initialRotation = transform.rotation;
        targetRotation = Quaternion.Euler(rotationAngle, 0, 0) * initialRotation;
    }

    void Update()
    {
        if (isRotatingToTarget)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            if (transform.rotation == targetRotation)
            {
                isRotatingToTarget = false;
            }
        }
    }

    public void ToggleRotation()
    {
        if (transform.rotation == initialRotation)
        {
            isRotatingToTarget = true;
            platform.PlatformActivate();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            ToggleRotation();
        }
    }
}
