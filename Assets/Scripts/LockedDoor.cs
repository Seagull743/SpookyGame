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

    //need to make it sound when locked, The problem is at the moment there is a box collider that blocks the raycast to create the lock effect but this means that the sound can't play
}
