using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTutorialScene : MonoBehaviour
{
    public float openHeight = 3.0f;
    public float speed = 2.0f;
    private Vector3 closedPosition;
    private Vector3 openPosition;
    private bool isOpening = false;
    private bool isClosing = false;

    void Start()
    {
        closedPosition = transform.position;
        openPosition = new Vector3(closedPosition.x, closedPosition.y + openHeight, closedPosition.z);
    }

    void Update()
    {
        if (isOpening)
        {
            transform.position = Vector3.MoveTowards(transform.position, openPosition, speed * Time.deltaTime);
            if (transform.position == openPosition)
            {
                isOpening = false;
            }
        }

    }

    public void OpenDoor()
    {
        isOpening = true;
        isClosing = false;
    }

}
