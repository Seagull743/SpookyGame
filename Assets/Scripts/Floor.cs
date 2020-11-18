using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : InteractiveObject
{
    private bool lightOn;
    public override void PlayerInteraction() 
    {
        PlayerEvent();
    }
    public void PlayerEvent()
    {
        ToggleLight();
        //player says somethign
    }

    public void ParanormalEvent()
    {
        ToggleLight();
        //broken bulb sound
    }


    private void ToggleLight()
    {
        if (lightOn)
        {
            lightOn = false;
        }
        else
        {
            lightOn = true;
        }
    }

   




}
