using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyDoorOpenScript : MonoBehaviour
{
    private Animator anim;
    public AudioSource SpookyDoorOpen;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    public void ParanormalDoorEvent()
    {
        
        anim.SetBool("SpookyDoorOpen", true);
        SpookyDoorOpen.Play();
    }


}
