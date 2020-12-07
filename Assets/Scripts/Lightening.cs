using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightening : MonoBehaviour
{
    private float timer;
    private float timer2;
    public Light DirectionalLight;
    private bool reset = false;
    public AudioSource thunder;
    
    void Awake()
    {
        DirectionalLight.enabled = false;
    }

    private void Start()
    {
        StartCoroutine(lightningflash());
    }



    // Update is called once per frame


    IEnumerator lightningflash()
    {
        yield return new WaitForSeconds(23);
        DirectionalLight.enabled = true;
        yield return new WaitForSeconds(0.3f);
        DirectionalLight.enabled = false;
        yield return new WaitForSeconds(0.3f);
        DirectionalLight.enabled = true;
        thunder.Play();
        yield return new WaitForSeconds(0.5f);
        DirectionalLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(60, 80));
        yield return StartCoroutine(lightningflash());
    }


}

