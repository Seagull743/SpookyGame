using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;


public class StateController : MonoBehaviour
{

    

    public State currentstate;
    public Transform eyes;
    public EnemyStats enemyStats;
    public State remainstate;


    [HideInInspector] public NavMeshAgent NavMeshAgent;
    [HideInInspector] public List<Transform> waypoints;
    [HideInInspector] public int nextWayPoint;
    /*[HideInInspector]*/ public Transform playerTarget;
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
            
            Vector3 eyePos = transform.position + new Vector3(0, eyes.localPosition.y, 0);

            Gizmos.color = Color.green;
            // Gizmos.DrawWireSphere(eyePos, .enemyStats.lookSphereCastRadius);
            Handles.color = Color.green;
            Handles.DrawWireArc(eyePos - transform.forward, Vector3.up, Vector3.forward, 360, enemyStats.lookSphereCastRadius);
            Vector3 viewAngleA = DirectionFromAngle(-enemyStats.viewAngle / 2, false);
            Vector3 viewAngleB = DirectionFromAngle(enemyStats.viewAngle / 2, false);
            Handles.DrawLine(eyePos - transform.forward, eyePos - transform.forward + viewAngleA * enemyStats.lookSphereCastRadius);
            Handles.DrawLine(eyePos - transform.forward, eyePos - transform.forward + viewAngleB * enemyStats.lookSphereCastRadius);

            Handles.color = Color.red;
        }  
    }

    public void TransitionToState(State nextState)
    {
        if(nextState != remainstate)
        {
            currentstate = nextState;
        }
    }

    public Vector3 DirectionFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.rotation.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    













}
