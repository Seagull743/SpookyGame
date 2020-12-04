using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightening : MonoBehaviour
{
    private float timer;
    private float timer2;
    public Light DirectionalLight;
    private bool reset = false;
    void Awake()
    {
        DirectionalLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > Random.Range(10, 20))
        {
            DirectionalLight.enabled = true;
            timer = 0;
            reset = true;
        }

        if(reset == true)
        {
            timer2 += Time.deltaTime;
            if(timer2 > 0.2)
            {
                DirectionalLight.enabled = false;
                timer2 = 0;
                reset = false;
            }
        }
    }
}
