using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Create EnemyProPlayer", fileName = "Enemigo", order = 0)]
public class EnemyProPlayer : EnemyCharacter

{
    private Animator _animator;
    private NavMeshAgent _agent;
    public void Initialize(NavMeshAgent agent, Animator animation)
    {
        _agent = agent;
        _animator = animation;
    }
    public override void EstadoIdle()
    {
        base.EstadoIdle();
        _agent.SetDestination(_agent.transform.position);
        UnityEngine.Debug.Log("Kieto");
    }
    public override void EstadoSeguir()
    {
        base.EstadoSeguir();
        _agent.SetDestination(target.transform.position);
        //UnityEngine.Debug.Log("siguiendo endo");
    }
    public override void EstadoAtacar()
    {
        base.EstadoAtacar();
        _agent.SetDestination(_agent.transform.position);
        _agent.transform.LookAt(target,Vector3.up);
        _animator.SetBool("Attack", true);
    }
    public override void EstadoMuerto()
    {
        base.EstadoMuerto();
        _agent.enabled = false;
        _animator.SetBool("Died" , true);
        //UnityEngine.Debug.Log("muriendo endo");
    }
    
}
