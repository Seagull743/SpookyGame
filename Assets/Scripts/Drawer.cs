using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : InteractiveObject
{
    public bool drawopened = false;
    private Animator anim;
    public AudioSource draweropensound;
    public AudioSource drawerclosesound;


    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
      
    }

    public override void PlayerInteraction()
    {
        DrawerOpen();
    }

    private void DrawerOpen()
    {
       drawopened = !drawopened;
        anim.SetBool("DrawOpened", drawopened);

        if (drawopened == true)
        {
            draweropensound.Play();
            
        }
        else if (drawopened == false)
        {
            drawerclosesound.Play();
            
        }
    }
}
