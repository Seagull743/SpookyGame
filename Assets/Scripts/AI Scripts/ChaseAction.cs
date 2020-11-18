using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{
    public override void Act(StateController controller)
    {
        
    }


    private void Chase(StateController controller)
    {
        controller.NavMeshAgent.destination = controller.playerTarget.position;
        controller.NavMeshAgent.Resume();
    }

}
