using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "PluggableAI/Actions/Patrol")]
public class PatrolAction : Action
{
    public override void Act(StateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(StateController controller)
    {
        controller.NavMeshAgent.destination = controller.waypoints[controller.nextWayPoint].position;
        controller.NavMeshAgent.isStopped = false;


        if(controller.NavMeshAgent.remainingDistance <= controller.NavMeshAgent.stoppingDistance && !controller.NavMeshAgent.pathPending)
        {
            controller.nextWayPoint = (controller.nextWayPoint + 1) % controller.waypoints.Count;
        }
    }
}
