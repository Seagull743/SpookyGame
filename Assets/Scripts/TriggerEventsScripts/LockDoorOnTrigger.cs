using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorOnTrigger : MonoBehaviour
{
    public GameObject Door;
    public LockedDoor LD;
    
    
    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            LD.LockDoor();
            Door.GetComponent<Animator>().SetBool("Opened", false);
            Destroy(gameObject);
        }
    }
       
    
}
