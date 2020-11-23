using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBulbTrigger : MonoBehaviour
{

    public TurnLight TL;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TL.BrokenBulbEvent();
            Destroy(gameObject);
        }
    }
}
