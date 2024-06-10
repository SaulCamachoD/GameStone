using UnityEngine;

public class BridgeMovable : MonoBehaviour
{
    public float closeAngle = -92f;
    public float openSpeed = 45f; // Angles per second

    private bool isOpen = false;
    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private bool isMoving = false;

    void Start()
    {
        initialRotation = transform.rotation;
        targetRotation = initialRotation;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * openSpeed);

            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                transform.rotation = targetRotation;
                isMoving = false;
            }
        }
    }

    public void ActivateBridgeEvent()
    {
        isOpen = !isOpen;
        targetRotation = isOpen ? Quaternion.Euler(closeAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z) : initialRotation;
        isMoving = true;
    }
}