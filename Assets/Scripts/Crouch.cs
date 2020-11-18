using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
  public  CharacterController PlayerController;
    
   

    private bool crouch = false;
    private float originalHeight;
    
    [SerializeField]
    private float crouchheight = 3.0f;
     void Start()
    {
        PlayerController = GetComponent<CharacterController>();
        originalHeight = PlayerController.height;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("I'm trying to crouch ");
            crouch = !crouch;

            CheckCrouch();
        }
        
    }

    void CheckCrouch()
    {
        if(crouch == true)
        {
            PlayerController.height = crouchheight;
        }
        else
        {
            PlayerController.height = originalHeight;
        }
    }



}
