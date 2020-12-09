﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTurn : MonoBehaviour
{
    public Animator anim;
    public AudioSource crossturn;
   
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TurnCross()
    {
        anim.SetBool("Turn", true);
        crossturn.Play();
    }

    
}
