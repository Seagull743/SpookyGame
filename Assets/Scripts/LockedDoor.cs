using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    
    public void UnlockDoor()
    {
        Debug.Log("door unlocked");
        GetComponent<BoxCollider>().enabled = false;
    }

    public void LockDoor()
    {
        GetComponent<BoxCollider>().enabled = true;
    }

}
