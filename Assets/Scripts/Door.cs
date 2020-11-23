using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : InteractiveObject
{

    private bool opened = false;
    private Animator anim;
    public AudioSource dooropensound;
    public AudioSource doorclosesound;
    
   

    // Start is called before the first frame update
    void Start()
    {

        
        anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
    
    public override void PlayerInteraction() 
    {
       DoorOpen();
    }

   

    


    private void DoorOpen()
    {
        opened = !opened;
        anim.SetBool("Opened", opened);

        if (opened == true)
        {
            dooropensound.Play();
           
        }
        else if (opened == false)
        {
            doorclosesound.Play();     
        }
    }
}
