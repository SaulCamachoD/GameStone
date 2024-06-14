using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{

    public float rotationAmount = 60f;
    public float rotationSpeed = 5f;
    private float currentRotation = 0f;
    private bool isRotating = false;
    private int rotationDirection = 1;
    private Quaternion targetRotation;
    public float PositionKey;

    void Update()
    {
        PositionKey = transform.localEulerAngles.y;
        RotateKey();
    }

    void RotateKey()
    {
        if (isRotating)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Quaternion.Angle(transform.rotation, targetRotation) < 1f)
            {
                transform.rotation = targetRotation;
                isRotating = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isRotating)
        {
            rotationDirection *= -1;
            currentRotation += rotationAmount * rotationDirection;
            if (currentRotation >= 360f)
            {
                currentRotation -= 360f;
            }
            targetRotation = Quaternion.Euler(0f, 0f, currentRotation) * transform.rotation;
            isRotating = true;
        }
    }
}


        
