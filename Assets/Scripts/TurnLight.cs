using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : InteractiveObject
{

    public GameObject light;
    public GameObject lightStand;
    public float maxlight = 20;
    public float Lightduration;
    public float Lightdrain = 1;
    private bool lighton = false;
    public AudioSource lightsound;
    public AudioSource BrokenBulbSound;
    public GameObject lightswitchpivot;

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


    IEnumerator FlashingLights()
    {

        if (lighton == true)
        {
            light.SetActive(false);
            yield return new WaitForSeconds(1);
            light.SetActive(true);
            yield return new WaitForSeconds(1);
            light.SetActive(false);
            yield return new WaitForSeconds(1);
            light.SetActive(true);
            yield return new WaitForSeconds(1);
            light.SetActive(false);
        }   
    }

    

    public void BrokenBulbEvent()
    {
        lighton = false;
        light.SetActive(false);
        lightStand.SetActive(false);
        BrokenBulbSound.Play();
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
        lightswitchpivot.transform.Rotate(-180.0f, 0.0f, 0.0f);
    }
      
    public void LightOff()
    {
        light.SetActive(false);
        lighton = false;
        lightsound.Play();
        lightswitchpivot.transform.Rotate(0.0f, 0.0f, 0.0f);
    }
         
                    
 }

