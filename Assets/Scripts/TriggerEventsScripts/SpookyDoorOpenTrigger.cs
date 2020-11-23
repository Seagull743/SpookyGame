using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyDoorOpenTrigger : MonoBehaviour
{
    public SpookyDoorOpenScript SpookyDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpookyDoor.ParanormalDoorEvent();
            Destroy(gameObject);
        }
    }
}
