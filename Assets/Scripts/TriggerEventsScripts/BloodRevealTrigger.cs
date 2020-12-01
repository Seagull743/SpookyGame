using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodRevealTrigger : MonoBehaviour
{
    public MonsterManager MM;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MM.BloodSpawn();
            Destroy(gameObject);
        }
    }

}
