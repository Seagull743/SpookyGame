using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorOnTrigger : MonoBehaviour
{
    public GameObject Door;
    public LockedDoor LD;
    
    
    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Locked the door");
            LD.LockDoor();
            gameObject.GetComponentInChildren<Animator>().SetBool("Opened", true);
        }
    }
       
    
}
