using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu (menuName = "PluggableAI/Decisions/LookV2")]
public class LookDecisionV2 : Decision
{
    [SerializeField] private LayerMask playerLM;
    [SerializeField] private LayerMask wallsOnly;
    

    private StateController controller;


    public override bool Decide (StateController controller)
    {
        bool targetvisible = Look(controller);
        return targetvisible;
    }

    //private bool Look(StateController controller)
    //{
    //    RaycastHit hit;

    //    Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.enemyStats.lookRange, Color.green);

    //    if(Physics.SphereCast(controller.eyes.position, controller.enemyStats.lookSphereCastRadius, controller.eyes.forward, out hit, controller.enemyStats.lookRange)
    //        && hit.collider.CompareTag("Player"))
    //    {

    //        Debug.Log("Can see the player");
    //        controller.playerTarget = hit.transform;
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}


        

    public bool Look(StateController controller)
    {
        //Debug.Log("words");

        this.controller = controller;


        Vector3 lookPos = controller.transform.position;
        lookPos.y = controller.eyes.transform.position.y;

        



        Collider[] targetsInViewRadius = Physics.OverlapSphere(lookPos, controller.enemyStats.lookSphereCastRadius, playerLM);


        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform player = GM.instance.player.transform;

            Vector3 dirToTarget = (player.position - (controller.transform.position - controller.transform.forward)).normalized;
    

            RaycastHit hit;

            if (Vector3.Angle(controller.transform.forward, dirToTarget) < controller.enemyStats.viewAngle / 2)
            {
                float dist = Vector3.Distance(lookPos, player.position);

                if (!Physics.Raycast(lookPos - controller.transform.forward, dirToTarget, out hit, dist, wallsOnly))
                {
                    Debug.Log("Can see the player");
                    
                    //Debug.DrawLine(lookPos, hit.point, Color.green);
                    

                    controller.gameObject.GetComponent<MonsterAudio>().Playchasesound();
                    return true;
                }

                else
                {
                    Debug.DrawLine(lookPos, hit.point, Color.blue);
                    controller.gameObject.GetComponent<MonsterAudio>().Stopchasesound();
                    return false;
                    
                }
            }
            else
            {
                controller.gameObject.GetComponent<MonsterAudio>().Stopchasesound();
                return false;
            }
        }
        controller.gameObject.GetComponent<MonsterAudio>().Stopchasesound();
        return false;

    }

    



}
