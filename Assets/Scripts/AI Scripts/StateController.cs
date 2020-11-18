using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{

    

    public State currentstate;
    public Transform eyes;
    public EnemyStats enemyStats;
    public State remainstate;


    [HideInInspector] public NavMeshAgent NavMeshAgent;
    [HideInInspector] public List<Transform> waypoints;
    [HideInInspector] public int nextWayPoint;
    [HideInInspector] public Transform playerTarget;
    private bool aiActive;

    private void Awake()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }


    public void SetupAI(bool aiActivationFromHorrorManager, List<Transform> wayPointsFromHorrorManager)
    {
        waypoints = wayPointsFromHorrorManager;
        aiActive = aiActivationFromHorrorManager;

        if (aiActive)
        {
            NavMeshAgent.enabled = true;
        }
        else
        {
            NavMeshAgent.enabled = false;
        }

    }

    void Update()
    {
        if (!aiActive)
            return;
        currentstate.UpdateState(this);
    }

    void OnDrawGizmos()
    {
        if (currentstate != null && eyes != null)
        {
            Gizmos.color = currentstate.SceneGizmocolor;
            Gizmos.DrawWireSphere(eyes.position, enemyStats.lookSphereCastRadius);
        }  
    }

    public void TransitionToState(State nextState)
    {
        if(nextState != remainstate)
        {
            currentstate = nextState;
        }
    }















}
