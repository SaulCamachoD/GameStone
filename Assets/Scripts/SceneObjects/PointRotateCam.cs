using UnityEngine;

public class PointRotateCam : MonoBehaviour
{
    private Quaternion startRotation;
    private Quaternion rotation45;
    private Quaternion rotation135;
    private Quaternion rotation90;
    private Quaternion endRotation;
    private bool isRotating = false;
    private bool rotatingForward = true;
    private float rotationTime = 0.0f;
    private float duration = 1.0f;

    void Start()
    {
        startRotation = Quaternion.Euler(30, -45, 0);
        rotation45 = Quaternion.Euler(30, 45, 0);
        rotation135 = Quaternion.Euler(30, 135, 0);
        rotation90 = Quaternion.Euler(30, -90, 0);
        transform.rotation = startRotation;
    }

    void Update()
    {
        if (isRotating)
        {
            rotationTime += Time.deltaTime / duration;

            transform.rotation = Quaternion.Lerp(rotatingForward ? startRotation : endRotation, rotatingForward ? endRotation : startRotation, rotationTime);

            if (rotationTime >= 1.0f)
            {
                isRotating = false;
                rotationTime = 0.0f; 
            }
        }
    }

    public void StartRotation45()
    {
        if (!isAtRotation(rotation45))
        {
            isRotating = true;
            rotatingForward = true;
            rotationTime = 0.0f;
            endRotation = rotation45;
        }
    }

    public void StartRotation135()
    {
        if (!isAtRotation(rotation135))
        {
            isRotating = true;
            rotatingForward = true;
            rotationTime = 0.0f;
            endRotation = rotation135;
        }
    }
    
    public void StartRotation90()
    {
        if (!isAtRotation(rotation90))
        {
            isRotating = true;
            rotatingForward = true;
            rotationTime = 0.0f;
            endRotation = rotation90;
        }
    }

    public void StartRotationOrigin()
    {
        if (!isAtRotation(startRotation))
        {
            isRotating = true;
            rotatingForward = false;
            rotationTime = 0.0f;
            endRotation = transform.rotation; 
        }
    }

    private bool isAtRotation(Quaternion targetRotation)
    {
        return Quaternion.Angle(transform.rotation, targetRotation) < 0.1f;
    }

}