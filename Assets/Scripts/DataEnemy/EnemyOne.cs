using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyOne : MonoBehaviour 
{
    public EnemyProPlayer enemyProPlayer;
    public Transform player;
    private NavMeshAgent _agent;

    void Awake()
    {
        //agente = GetComponent<NavMeshAgent>();
        enemyProPlayer = ScriptableObject.CreateInstance<EnemyProPlayer>();
    }

    void Start()
    {
        StartCoroutine(enemyProPlayer.CalculateDistance(transform));
        enemyProPlayer.Initialize(_agent);
        enemyProPlayer.Position(player);
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

    public void Idle()
    {
        enemyProPlayer.EstadoIdle();
        //agent.SetDestination(agente.transform.position);
        
    }
    public void Seguir()
    {
        enemyProPlayer.EstadoSeguir();
       
    }

    public void Atacar()
    {
        enemyProPlayer.EstadoAtacar();
        //agent.SetDestination(agente.transform.position);
        //agent.transform.LookAt(player, Vector3.up);
        UnityEngine.Debug.Log("matando ando");
    }

    public void Muerto()
    {
        enemyProPlayer.EstadoAtacar();
    }
}

