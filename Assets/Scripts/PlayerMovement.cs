using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;


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
        //playerfootsteps.volumeMin = walkvolumemin;
        //playerfootsteps.VolumeMax = walkvolimemax;
        //playerfootsteps.stepdistance = walkStepDistance;


    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // "gravity"
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveAmount = transform.right * x + transform.forward * z;

        moveAmount = moveAmount * speed * Time.deltaTime;

        if (!isGrounded) //&& velocity.y < 0
        {
            moveAmount.y += gravity * Time.deltaTime;
        }
        else
        {
            moveAmount.y = 0;
        }

        controller.Move(moveAmount);

        //playerfootsteps.stepdistance = walkStepDistance;
        //playerfootsteps.volumeMin = walkvolumemin;
        //playerfootsteps.VolumeMax = walkvolimemax;

        //velocity.y += gravity * Time.deltaTime;

        //controller.Move(velocity * Time.deltaTime);
    }



}


