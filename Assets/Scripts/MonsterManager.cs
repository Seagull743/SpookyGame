using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public StateController state;
    public bool aiActive;
    public List<Transform> waypoints;
    
    // Start is called before the first frame update
    void Start()
    {
        state.SetupAI(aiActive, waypoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
