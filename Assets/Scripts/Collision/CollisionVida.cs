using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionVida : MonoBehaviour
{
    public int hp;
    public int dañoArma;
    public int dañoPuño;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("armaImpactos"))
        {
            if (anim !=null)
            {
                anim.Play("AnimacionDamage");
            }
            hp -= dañoArma;
        }
        if (hp < 0)
        {
            Destroy(gameObject);
        }
    }
}
