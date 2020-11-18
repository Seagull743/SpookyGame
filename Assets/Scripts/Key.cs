using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : InteractiveObject

{
    public LockedDoor ld;
    public GameObject key;

    public override void PlayerInteraction() 
    {
        GotKey();
    }


    private void GotKey()
    {
        Debug.Log("got Key");
        ld.UnlockDoor();
        Destroy(key);
    }

}
