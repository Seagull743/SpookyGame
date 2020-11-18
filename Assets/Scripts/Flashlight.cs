using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    public Light light;
    public AudioSource clicksound;
    private bool lighton = false;

    public static float BatteryLife = 0.0f;
    public float lightDrain = 0.1f;
    public float maxBatteryLife = 99.0f;
    public float miniumBatteryLife = 80.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        BatteryLife = maxBatteryLife;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(lighton && BatteryLife >= 0)
        {
            BatteryLife -= Time.deltaTime * lightDrain;
        }


        if (BatteryLife <= miniumBatteryLife)
        {
            light.intensity = miniumBatteryLife;
            BatteryLife = miniumBatteryLife;
        }



        light.intensity = BatteryLife;

      

        
        //Turn torch on
        if (Input.GetMouseButtonDown(0))
        {
          if (lighton == true)
            {
                Off();
            }
            else if (!lighton && BatteryLife >= 0)
            {
                On(); 
            }
        
        }
    }

    public void PickedUpBattery()
    {
        BatteryLife = maxBatteryLife;
    }

    public void On()
    {
        light.enabled = true;
        clicksound.Play();
        lighton = true;
    }

    public void Off()
    {
        light.enabled = false;
        clicksound.Play();
        lighton = false;
    }
}
