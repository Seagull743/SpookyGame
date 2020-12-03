using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockingChairTrigger : MonoBehaviour
{

    public RockingChairAnimation chair;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chair.RockingChair();
            Destroy(gameObject);
        }
    }

}
