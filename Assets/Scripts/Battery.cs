using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : InteractiveObject
{
   
    public Flashlight FL;
    public GameObject Batteries;
    public AudioSource PickUpSound;

    public override  void PlayerInteraction() 
    {
        BatteryPickup();  
    }

    public void BatteryPickup()
    {
        FL.PickedUpBattery();
        PickUpSound.Play();
        Destroy(Batteries);
    }



}
