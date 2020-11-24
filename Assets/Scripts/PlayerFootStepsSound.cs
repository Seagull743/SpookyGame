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


    // Start is called before the first frame update
    void Awake()
    {
        footstepsound = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckToPlayFootSound();
    }


    public void CheckToPlayFootSound()
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
