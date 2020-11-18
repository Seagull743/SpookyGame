using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFXphone : MonoBehaviour
{
    public AudioSource PlayPhoneSound;

    private void OnTriggerEnter(Collider other)
    {
        PlayPhoneSound.Play();
        Destroy(gameObject);
    }

}
