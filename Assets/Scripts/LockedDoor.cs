using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{

    public AudioSource DoorCloseSound;
    public GameObject boxCollider;
 
    private void Start()
    {
      boxCollider.GetComponent<BoxCollider>().enabled = false;
    }



    public void UnlockDoor()
    {
        Debug.Log("door unlocked");
        boxCollider.GetComponent<BoxCollider>().enabled = false;     
    }

    public void LockDoor()
    {
        boxCollider.GetComponent<BoxCollider>().enabled = true;

        DoorCloseSound.Play();
    }

    
}
