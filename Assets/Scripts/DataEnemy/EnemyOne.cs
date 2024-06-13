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
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        //enemyProPlayer = ScriptableObject.CreateInstance<EnemyProPlayer>();
    }
    void Start()
    {
        enemyProPlayer.Position(player);
        enemyProPlayer.Initialize(agent);
        StartCoroutine(enemyProPlayer.CalculateDistance(transform));
    }
    private void LateUpdate()
    {
        
        enemyProPlayer.CheckEstado();
        
    }
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        enemyProPlayer.OnDrawGuizmosSelected(transform) ;
    }
#endif
     
}

