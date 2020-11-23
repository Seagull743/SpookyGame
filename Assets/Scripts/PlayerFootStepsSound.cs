using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootStepsSound : MonoBehaviour
{

    
    private AudioSource footstepsound;
    [SerializeField]
    private AudioClip[] footstepclip;

    private CharacterController characterController;

    public float volumeMin, VolumeMax;

    private float accumalatedDistance;
    
    
    public float stepdistance;

    private AudioSource footstepsoundtiles;
    [SerializeField]
    private AudioClip[] footsteptileclips;


    // Start is called before the first frame update
    void Awake()
    {
        footstepsound = GetComponent<AudioSource>();
        footstepsoundtiles = GetComponent<AudioSource>();

        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckToPlayFootSound();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tiles")
        {
            if (characterController.velocity.sqrMagnitude > 0)
            {
                accumalatedDistance += Time.deltaTime;

                if (accumalatedDistance > stepdistance)
                {
                    footstepsoundtiles.volume = Random.Range(volumeMin, VolumeMax);
                    footstepsoundtiles.clip = footsteptileclips[Random.Range(0, footsteptileclips.Length)];
                    footstepsoundtiles.Play();

                    accumalatedDistance = 0f;
                }
            }
       
         else if(collision.gameObject.tag == "Wood")
            {
            if (characterController.velocity.sqrMagnitude > 0)
                {
                    accumalatedDistance += Time.deltaTime;

                if (accumalatedDistance > stepdistance)
                    {
                    footstepsound.volume = Random.Range(volumeMin, VolumeMax);
                    footstepsound.clip = footstepclip[Random.Range(0, footstepclip.Length)];
                    footstepsound.Play();

                    accumalatedDistance = 0f;
                    }
                }
                else
                {
                    accumalatedDistance = 0f;
                }
            }
        }
    }


    public void CheckToPlayFootSound()
    {
     //if (characterController.velocity.sqrMagnitude > 0)
               // {
                   // accumalatedDistance += Time.deltaTime;

              //  if (accumalatedDistance > stepdistance)
               //     {
               //     footstepsound.volume = Random.Range(volumeMin, VolumeMax);
               //     footstepsound.clip = footstepclip[Random.Range(0, footstepclip.Length)];
               //     footstepsound.Play();
      
                  //  accumalatedDistance = 0f;
             //       }
              //  }
              //  else
             //   {
             //       accumalatedDistance = 0f;
             //   }
    }


}
