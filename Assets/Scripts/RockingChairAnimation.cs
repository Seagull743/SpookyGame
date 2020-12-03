using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockingChairAnimation : MonoBehaviour
{

    public Animator anim;
    public AudioSource chairsound;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();

        timer += Time.deltaTime;
    }

    public void RockingChair()
    {
        anim.SetBool("Rock", true);
        chairsound.Play();

        if (timer > 15)
        {
            
            anim.SetBool("Rock", false);
        }
    }
   
}
