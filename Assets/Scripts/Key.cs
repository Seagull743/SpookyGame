using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : InteractiveObject

{
    public LockedDoor ld;
    public GameObject key;
    public LockedDoorSound LDS;
    public override void PlayerInteraction() 
    {
        GotKey();
    }


    private void GotKey()
    {
        Debug.Log("got Key");
        LDS.GetComponent<LockedDoorSound>().enabled = false;
        ld.UnlockDoor();
        Destroy(key);
    }

}
