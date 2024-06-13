using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GemaMovements : MonoBehaviour
{
    public Transform personaje;
    public Animations animations;
    public float distanciaMaxima = 1f;
    public bool CanPush = false;
    public float offsetDistancia = 2f;

    private Transform rocaPadreOriginal;
    private bool isPushing = false;

    
    public event Action<bool> OnPushStateChanged;

    void Start()
    {
        rocaPadreOriginal = transform.parent;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanPush)
        {
            if (!isPushing)
            {
                animations.PushanimationActive();
                transform.SetParent(personaje);
                isPushing = true;
                OnPushStateChanged?.Invoke(true); 
            }
            else
            {
                animations.PushanimationDesActive();
                transform.SetParent(rocaPadreOriginal);
                isPushing = false;
                OnPushStateChanged?.Invoke(false); 
            }
        }

        if (isPushing)
        {
            Vector3 offsetPosition = personaje.position + personaje.forward * offsetDistancia;
            transform.position = offsetPosition;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == personaje)
        {
            float distancia = Vector3.Distance(transform.position, personaje.position);
            if (distancia <= distanciaMaxima)
            {
                CanPush = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == personaje)
        {
            CanPush = false;
            if (isPushing)
            {
                animations.PushanimationDesActive();
                transform.SetParent(rocaPadreOriginal);
                isPushing = false;
                OnPushStateChanged?.Invoke(false); 
            }
        }
    }
}