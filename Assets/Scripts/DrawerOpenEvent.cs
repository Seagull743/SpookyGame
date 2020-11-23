using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpenEvent : MonoBehaviour
{
    public bool drawopened = false;
    private Animator anim;
    public AudioSource draweropensound;
    public AudioSource drawerclosesound;


    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
    }

    
   public void DrawerOpen()
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
