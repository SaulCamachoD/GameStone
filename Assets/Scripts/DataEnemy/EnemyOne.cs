using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyOne : MonoBehaviour
{
    //ublic EnemyCharacter enemyCharacter;
    public EnemyProPlayer enemyProPlayer;
    public Transform player;
    public NavMeshAgent agent;
    public Animator animator;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        //enemyProPlayer = ScriptableObject.CreateInstance<EnemyProPlayer>();
    }
    void Start()
    {
        enemyProPlayer.Position(player);
        enemyProPlayer.Initialize(agent , animator);
        StartCoroutine(enemyProPlayer.CalculateDistance(transform));
    }
    private void LateUpdate()
    {
        
        enemyProPlayer.CheckEstado(transform);
        
    }
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        enemyProPlayer.OnDrawGuizmosSelected(transform) ;
    }
#endif
     
}

