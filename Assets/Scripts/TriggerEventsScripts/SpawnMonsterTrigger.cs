using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterTrigger : MonoBehaviour
{

    public MonsterManager MM;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MM.SpawnMonster();
        }
    }
}
