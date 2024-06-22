using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Animations : MonoBehaviour
{   
    public Animator animator;   
    PlayerVariables playerVariables;
    public float meleeCooldown = 1f; 
    public float distanceCooldown = 2f;
    private bool canMeleeAttack = true;
    private bool canDistanceAttack = true;
    public VisualEffect swordVFX;
    

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
                if (swordVFX)
                {
                    swordVFX.gameObject.SetActive(true);
                    swordVFX.SetBool("UseForce",true);
                    StartCoroutine(DeactivateVFXAfterDelay(2f));
                }
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
    IEnumerator DeactivateVFXAfterDelay(float delay)
    {
        swordVFX.SetBool("UseForce",false);
        yield return new WaitForSeconds(delay);
        swordVFX.gameObject.SetActive(false);
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
