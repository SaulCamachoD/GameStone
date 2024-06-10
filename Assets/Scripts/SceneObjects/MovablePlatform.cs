using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePlatform : MonoBehaviour
{
    public Rigidbody RbPlatform;
    public Transform[] target;
    public float speed = 1f;

    private int currentPosition = 0;
    private int nextPosition = 1;
    private float _xInitialPos;
    private float _yInitialPos;
    private float _zInitialPos;
    private float _waitTime = 1f;
    private bool _activate = false;

    private void Start()
    {
        _xInitialPos = transform.position.x;
        _yInitialPos = transform.position.y;
        _zInitialPos = transform.position.z;
    }

    private void Update()
    {
        if (_activate)
        {
            MovePlatform(); 
        }
    }

    public void MovePlatform()
    {
       
        StopCoroutine(WaitForMove(0));
        Vector3 newPosition = Vector3.MoveTowards(RbPlatform.position, target[nextPosition].position, speed * Time.deltaTime);
        RbPlatform.MovePosition(newPosition);
    

        if (Vector3.Distance(RbPlatform.position, target[nextPosition].position) <= 0.1f) 
        {
            StartCoroutine(WaitForMove(_waitTime));
            currentPosition = nextPosition;
            nextPosition++;

            if (nextPosition > target.Length - 1)
            {
                nextPosition = 0;
            }
        }
    }

    public void ResetPlatform()
    {
        transform.position = new Vector3(_xInitialPos, _yInitialPos, _zInitialPos);
        _activate = false;
        currentPosition = 0;
        nextPosition = 1;
    }

    public void PlatformActivate()
    {
        _activate = true;
    }

    IEnumerator WaitForMove(float time)
    {
        _activate = false;
        yield return new WaitForSeconds(time);
        _activate = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform); 
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.parent != transform)
            {
                collision.transform.SetParent(transform); 
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.parent == transform)
            {
                collision.transform.SetParent(null);
            }
        }
    }
}