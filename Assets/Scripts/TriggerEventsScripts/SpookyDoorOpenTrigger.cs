﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyDoorOpenTrigger : MonoBehaviour
{
    public Door door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.DoorOpen();
            Destroy(gameObject);
        }
    }
}
