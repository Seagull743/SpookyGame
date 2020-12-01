using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public StateController state;
    public bool aiActive;
    public List<Transform> waypoints;
    public GameObject Monster;
    public bool MonsterActive = false;
    public GameObject blood;


    // Start is called before the first frame update
    void Start()
    {
        state.SetupAI(aiActive, waypoints);
        Monster.SetActive(false);
        blood.SetActive(false);
    }

    
    // Monster

    public void SpawnMonster()
    {
        while (MonsterActive == false)
        StartCoroutine(MonsterSpawner());
    }

    IEnumerator MonsterSpawner()
    {
        MonsterActive = true;    
        yield return new WaitForSeconds(3);
        Monster.SetActive(true);
        yield return new WaitForSeconds(Random.Range(12f, 20f));
        Monster.SetActive(false);
        yield return new WaitForSeconds(Random.Range(10f, 15f));
        yield return MonsterActive = false;

        
        
    }

    IEnumerator DespawnMonster()
    {
        MonsterActive = false;
        yield return new WaitForSeconds(Random.Range(10, 20));
        Monster.SetActive(false);
    }


    // Paranormal Events


    public void BloodSpawn()
    {
        blood.SetActive(true);
    }



}
