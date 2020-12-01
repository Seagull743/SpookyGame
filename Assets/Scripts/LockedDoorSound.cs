using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorSound : InteractiveObject
{

    public AudioSource LockedSound;




    public override void PlayerInteraction()
    {
        LockSound();
    }

    public void LockSound()
    {
        LockedSound.Play();
    }


}
