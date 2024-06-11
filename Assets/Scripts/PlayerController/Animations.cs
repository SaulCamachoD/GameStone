using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{   
    public Animator animator;   
    PlayerVariables playerVariables;
    void Start()
    {
        playerVariables = GetComponent<PlayerVariables>();
    }
    void Update()
    {
        animator.SetFloat("VelZ", playerVariables.movInZ);
        animator.SetFloat("VelX", playerVariables.movInX);
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("Spell");
        }
    }

    public void DashAnimation()
    {
        animator.SetTrigger("Dash");
    }
}
