using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    private PlayerFootStepsSound playerfootsteps;
    private float walkvolumemin = 0.2f;
    private float walkvolimemax = 0.4f;


    private float walkStepDistance = 0.7f;

    private void Awake()
    {
        playerfootsteps = GetComponent<PlayerFootStepsSound>();
    }


    void Start()
    {
        playerfootsteps.volumeMin = walkvolumemin;
        playerfootsteps.VolumeMax = walkvolimemax;
        playerfootsteps.stepdistance = walkStepDistance;


    }

    // Update is called once per frame
    void Update()
    { 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        playerfootsteps.stepdistance = walkStepDistance;
        playerfootsteps.volumeMin = walkvolumemin;
        playerfootsteps.VolumeMax = walkvolimemax;
       

    }



}


