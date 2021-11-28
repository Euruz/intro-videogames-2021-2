using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdleState : AIState
{
    private float ActTime;
    [SerializeField] 
    private float patrolTime = 7f;

    public AIStateID GetID()
    {
        return AIStateID.Idle;
    }

    public void Enter(AIAgent agent)
    {
        ActTime = patrolTime;
    }

    public void Update(AIAgent agent)
    {
        //TODO: Agregar timer para ir a Patrol
        ActTime += Time.deltaTime;
        if (ActTime >= 0) {
            agent.StateMachine.ChangeState(AIStateID.Patrol);
            ActTime = 0;
        }
        //Si el player esta cerca -> Chase
        Vector3 targetDirection = agent.Target.position - agent.transform.position;
        if (targetDirection.magnitude > agent.AIConfig.detectionRange)
        {
            return;
        }
        
        //Si esta viendo al player
        if (agent.IsLookingTarget())
        {
            agent.StateMachine.ChangeState(AIStateID.ChaseTarget);
        }
    }

    public void Exit(AIAgent agent)
    {
    }
}
