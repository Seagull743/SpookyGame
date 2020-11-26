using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAudio : MonoBehaviour
{
    public AudioSource chasesound;
    public AudioSource AttackSound;


    public void Playchasesound()
    {

        if (!chasesound.isPlaying)
        {
            chasesound.Play();
        }
       
    }

    public void Stopchasesound()
    {
        chasesound.Stop();
    }


    public void Attacksound()
    {
        AttackSound.Play();
    }

    public void AttackSoundStop()
    {
        
    }

}
