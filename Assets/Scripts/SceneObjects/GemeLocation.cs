using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemeLocation : MonoBehaviour
{
    [SerializeField] private float Xinicial;
    [SerializeField] private float Yinicial;
    [SerializeField] private float Zinicial;
    void Start()
    {
        Xinicial = transform.position.x;
        Yinicial = transform.position.y;
        Zinicial = transform.position.z;
    }

    public void InicialLocation()
    {
        transform.position = new Vector3(Xinicial, Yinicial, Zinicial);
    }
}
