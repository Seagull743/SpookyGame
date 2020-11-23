using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "PluggableAI/Decisions/Look")]
public class LookDecisionV2 : Decision
{
    private List<GameObject> playerTracker = new List<GameObject>();
    private List<Collider> thingsIThinkICanSee = new List<Collider>();
    private List<GameObject> thingsICanSee = new List<GameObject>();
    private LayerMask playerLM;

    public override bool Decide (StateController controller)
    {
        bool targetvisible = Look(controller);
        return targetvisible;
    }

    private bool Look(StateController controller)
    {
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.enemyStats.lookRange, Color.green);

        if(Physics.SphereCast(controller.eyes.position, controller.enemyStats.lookSphereCastRadius, controller.eyes.forward, out hit, controller.enemyStats.lookRange)
            && hit.collider.CompareTag("Player"))
        {

            Debug.Log("Can see the player");
            controller.playerTarget = hit.transform;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void LookV2(StateController controller)
    {
        playerTracker.Clear();
        thingsIThinkICanSee.Clear();
        thingsICanSee.Clear();

        Collider[] targetsInViewRadius = Physics.OverlapSphere(controller.eyes.position, controller.enemyStats.lookSphereCastRadius, playerLM);
        foreach (Collider c in targetsInViewRadius)
        {
            thingsIThinkICanSee.Add(c);
        }

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            playerTracker.Clear();
            thingsICanSee.Clear();


            Transform player = GM.instance.player.transform;

            Vector3 dirToTarget = (player.position - (controller.transform.position - controller.transform.forward)).normalized;



        //    if (Vector3.Angle(transform.forward, dirToTarget) < viewAngle / 2)
        //    {

        //        float dist = Vector3.Distance(transform.position + new Vector3(0, eyeHeight, 0), player.position);
        //        if (!Physics.Raycast((transform.position + new Vector3(0, eyeHeight, 0)) - transform.forward, dirToTarget, out hit, dist, wallsOnlyLM))
        //        {
        //            playerTracker.Add(player);
        //            thingsICanSee.Add(player);
        //            lastKnownPos = player.position;
        //            distanceToLastKnownPos = dist;
        //            myEyes = EyeStates.canSeePlayer;
        //            hasSeenPlayer = true;
        //            FinishedState(myBrain, BrainStates.attackMode);
        //            Debug.DrawLine(transform.position + new Vector3(0, eyeHeight, 0), hit.point, Color.green);
        //        }

        //        else
        //        {
        //            playerTracker.Clear();
        //            thingsICanSee.Clear();
        //            Debug.DrawLine(transform.position + new Vector3(0, eyeHeight, 0), hit.point, Color.blue);
        //            myEyes = EyeStates.cantSeePlayer;
        //        }
        //    }
        //}

        //if (targetsInViewRadius.Length == 0)
        //{
        //    myEyes = EyeStates.cantSeePlayer;
        }
    }


}
