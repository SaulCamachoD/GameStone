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
    public GameObject Gema;
    public BossDoor bossDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("armaImpacto"))
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
            Gema.SetActive(true);
            bossDoor.ActiveDoorEvent();
        }
    }
}
