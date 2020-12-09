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
    public GameObject LightBulbOn;
    public bool LightBulbbreak;
    
    void Start()
    {
        Lightduration = maxlight;
        light.SetActive(false);
        LightBulbOn.SetActive(false);
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


    public void StartLightEvent()
    {
        StartCoroutine(FlashingLights());
    }
    
    
    public 



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
        if(lighton == true)
        {
            lighton = false;
            light.SetActive(false);
            lightStand.SetActive(false);
            BrokenBulbSound.Play();
            LightBulbOn.SetActive(false);
            LightBulbbreak = true;
            
        }
        
       
    }

    public void LightSwitchToggle()
    {
        if (lighton == true)
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
        if(LightBulbbreak == true)
        {
            light.SetActive(false);
            LightBulbOn.SetActive(false);
            lighton = true;
            lightsound.Play();
            lightswitchpivot.transform.Rotate(-180.0f, 0.0f, 0.0f);
        }
        else
        {
           light.SetActive(true);
           LightBulbOn.SetActive(true);
           lighton = true;
           lightsound.Play();
           lightswitchpivot.transform.Rotate(-180.0f, 0.0f, 0.0f);
        }
        
      
    }

    public void LightOff()
    {
        if(LightBulbbreak == true)
        {
            light.SetActive(false);
            LightBulbOn.SetActive(false);
            lighton = false;
            lightsound.Play();
            lightswitchpivot.transform.Rotate(180.0f, 0.0f, 0.0f);
        }
        else
        {
            light.SetActive(false);
            LightBulbOn.SetActive(false);
            lighton = false;
            lightsound.Play();
            lightswitchpivot.transform.Rotate(180.0f, 0.0f, 0.0f);
        }
      
    }

}              

