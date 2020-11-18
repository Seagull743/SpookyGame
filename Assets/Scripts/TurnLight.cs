using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : InteractiveObject
{

    public GameObject light;

    public float maxlight = 20;
    public float Lightduration;
    public float Lightdrain = 1;
    private bool lighton = false;
    public AudioSource lightsound;

     void Start()
    {
        Lightduration = maxlight;   
    }

    public override void PlayerInteraction() 
    {
        LightSwitchToggle();
    }


    void Update()
    {
        if (lighton && Lightduration >= 0)
        {
           Lightduration -= Time.deltaTime * Lightdrain;
        }
        
        if (Lightduration <= 0)
        {
            LightOff();
            Lightduration = maxlight; 
        }
    }



    public void LightSwitchToggle()
    {
        if(lighton == true)
        {
            LightOff();
        }
        else 
        {
            LightOn(); 
        }
    }

    
    public void LightOn()
    {
      
        light.SetActive(true);
        lighton = true;
        lightsound.Play();
    }
      
    public void LightOff()
    {
        light.SetActive(false);
        lighton = false;
        lightsound.Play();
    }
         
                    
 }

