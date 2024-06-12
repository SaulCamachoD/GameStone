using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Create EnemyProPlayer", fileName = "Enemigo", order = 0)]
public class EnemyProPlayer : EnemyCharacter
{
    private NavMeshAgent _agent;

    public void Initialize(NavMeshAgent agent)
    {
        _agent = agent;
    }
    
    public override void EstadoIdle()
    {
        base.EstadoIdle();
        
        UnityEngine.Debug.Log("Kieto");
    }
    public override void EstadoSeguir()
    {
        
        base.EstadoSeguir();
        
        UnityEngine.Debug.Log("siguiendo endo");
    }
    public override void EstadoAtacar()
    {
        base.EstadoAtacar();
        
    }
    public override void EstadoMuerto()
    {
        base.EstadoMuerto();
        
        UnityEngine.Debug.Log("muriendo endo");
    }
}
