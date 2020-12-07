using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[CreateAssetMenu (menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{
    
    public override void Act(StateController controller)
    {
        Chase(controller);
    }


    private void Chase(StateController controller)
    {
       
        if(controller.NavMeshAgent.isOnNavMesh)
        {
            controller.NavMeshAgent.destination = controller.playerTarget.position;
            controller.NavMeshAgent.isStopped = false;
        }



    }

}
