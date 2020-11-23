using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycast : MonoBehaviour
{
    public Transform PlayerCamera;
   
    public static float MaxDistance = 20;
    
    

     void Start()
    {
        
    }


    void Update()
    {

        
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pressed();

        }
    }



    
    

   


    void Pressed()
    {

        RaycastHit hit;

        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, MaxDistance))
        {
            GameObject hitObject = hit.transform.gameObject;
           



            if (hitObject.GetComponent<InteractiveObject>())
            {
                hitObject.GetComponent<InteractiveObject>().PlayerInteraction();
            }

           

        }
       
    
    }

     



}
  