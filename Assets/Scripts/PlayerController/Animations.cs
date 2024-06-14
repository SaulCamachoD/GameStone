using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{   
    public Animator animator;   
    PlayerVariables playerVariables;
    public float meleeCooldown = 1f; 
    public float distanceCooldown = 2f;
    private bool canMeleeAttack = true;
    private bool canDistanceAttack = true;

    void Start()
    {
        playerVariables = GetComponent<PlayerVariables>();
    }
    private IEnumerator MeleeAttackCooldown()
    {
        canMeleeAttack = false;
        yield return new WaitForSeconds(meleeCooldown);
        canMeleeAttack = true;
    }
    private IEnumerator DistanceAttackCooldown()
    {
        canDistanceAttack = false;
        yield return new WaitForSeconds(distanceCooldown);
        canDistanceAttack = true;
    }
    void Update()
    {
        animator.SetFloat("VelZ", playerVariables.movInZ);
        animator.SetFloat("VelX", playerVariables.movInX);
        if (Input.GetMouseButtonDown(0) && canMeleeAttack)
        {
            if (playerVariables.currentWeapon is WeaponMelee)
            {
                animator.SetTrigger("Attack");
                playerVariables.currentWeapon.Use(transform.forward);
                StartCoroutine(MeleeAttackCooldown());
            }
        }
        
        if (Input.GetMouseButtonDown(1) && canDistanceAttack)
        {
            if (playerVariables.currentWeapon is WeaponDistance)
            {
                animator.SetTrigger("Spell");
                playerVariables.currentWeapon.Use(transform.forward);
                StartCoroutine(DistanceAttackCooldown());
            }
        }
    }

    public void DashAnimation()
    {
        animator.SetTrigger("Dash");
    }

    public void PushanimationActive()
    {
        animator.SetBool("Push",true);
    }
    public void PushanimationDesActive()
    {
        animator.SetBool("Push",false);
    }
}
