using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootStepsSound : MonoBehaviour
{

    
    private AudioSource footstepsound;
    [SerializeField]
    private AudioClip[] footstepclip;

    private CharacterController characterController;

    private Vector2 horizontalVelocity;

    public float volumeMin, VolumeMax;

    private float accumalatedDistance;
    
    public float stepdistance;

    public float footstepVolume;

    //playermovement here

    // Start is called before the first frame update
    void Awake()
    {
        footstepsound = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerVelocity = characterController.velocity;
        horizontalVelocity.x = playerVelocity.x;
        horizontalVelocity.y = playerVelocity.z;
        Debug.Log(horizontalVelocity.magnitude);

        //if playermovement.isGrounded == true {
        CheckToPlayFootSound();
    }


    public void CheckToPlayFootSound()
    {
 

        if (horizontalVelocity.magnitude > 0)
        {
            accumalatedDistance += Time.deltaTime;

            if (accumalatedDistance > stepdistance)
            {
                footstepsound.volume = footstepVolume;          // Random.Range(volumeMin, VolumeMax);
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
