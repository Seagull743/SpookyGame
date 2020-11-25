using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PluggableAI/EnemyStats")]
public class EnemyStats : ScriptableObject
{
    public float moveSpeed = 1;
    public float lookRange = 20f;
    public float lookSphereCastRadius = 2f;
    public float viewAngle = 45;
    public float AttackRange = 1;

    public float searchDuration = 4f;
    public float SearchingTurnSpeed = 120f;

}
