using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : InteractiveObject

{
    public AudioSource Pickupsound;
    public LockedDoor ld;
    public GameObject key;
    public LockedDoorSound LDS;
    public GM gm;
    public override void PlayerInteraction() 
    {
        GotKey();
    }


    private void GotKey()
    {
        Debug.Log("got Key");
        Pickupsound.Play();
        LDS.GetComponent<LockedDoorSound>().enabled = false;
        ld.UnlockDoor();
        gm.Normalcross();
        Destroy(key);
    }

}
