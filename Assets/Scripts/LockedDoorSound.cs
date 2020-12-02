using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorSound : InteractiveObject
{

    public AudioSource LockedSound;
    public GameObject DoorLockedText;


    void Start()
    {
        DoorLockedText.SetActive(false);
    }



    public override void PlayerInteraction()
    {
        LockSound();
    }

    public void LockSound()
    {
        LockedSound.Play();
        StartCoroutine(textLocked());
    }


    IEnumerator textLocked()
    {
        DoorLockedText.SetActive(true);
        yield return new WaitForSeconds(2);
        DoorLockedText.SetActive(false);
    }

}
