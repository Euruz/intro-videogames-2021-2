using UnityEngine;
public class AIPatrolState : AIState
{
    private PathContainer _pathContainer;
    private Vector3 _point;
    public AIStateID GetID()
    {
        return AIStateID.Patrol;
    }

    public void Enter(AIAgent agent)
    {
        _pathContainer = agent.GetComponent<PathContainer>();
        _point = _pathContainer.CurrentPoint();
    }

    public void Update(AIAgent agent)
    {
        agent.MovableAgent.GoTo(_point,() =>
            {
                OnArrive(agent);
            });
        Vector3 targetDirection= agent.Target.position - agent.transform.position;
        if (agent.IsLookingTarget() && targetDirection.magnitude <= agent.AIConfig.detectionRange)
        {
            agent.StateMachine.ChangeState(AIStateID.ChaseTarget);
        }
    }
    //github por favor deja de ser tan pesado
    private void OnArrive(AIAgent agent)
    {
        _point = _pathContainer.NextPoint();
    }
    public void Exit(AIAgent agent)
    {
        agent.MovableAgent.Stop();
    }
}
