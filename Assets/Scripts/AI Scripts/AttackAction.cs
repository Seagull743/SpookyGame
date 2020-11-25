using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Attack")]
public class AttackAction : Action
{
   
   
    public override void Act(StateController controller)
    {
        Attack (controller);
    }

    private void Attack(StateController controller)
    {
        
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.enemyStats.AttackRange, Color.red);

        if (Physics.Raycast(controller.eyes.position, controller.eyes.forward, out hit, controller.enemyStats.AttackRange) && hit.collider.CompareTag("Player"))
        {
            Debug.Log("Got you");
        }
        
        
        //check if player is close enough to be attacked
        //if they are then do attack
            //sound
            //make player fall over
            //you died screen
            //post processing 

    }

}
