using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Note : InteractiveObject
{

    public GameObject playerObject;
    
    public GameObject noteImage;

   // public AudioSource pickupSound;



    // Start is called before the first frame update
    void Start()
    {
        noteImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override  void PlayerInteraction() 
    {
        ShowNoteImage();  
    }


    public void ShowNoteImage()
    {
        noteImage.SetActive(true);
        playerObject.GetComponent<CharacterController>().enabled = false;
        playerObject.GetComponentInChildren<Mouselook>().enabled = false;
        playerObject.GetComponentInChildren<Flashlight>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //pickupSound.Play();
    }

    public void HideNoteImage()
    {
        noteImage.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        playerObject.GetComponent<CharacterController>().enabled = true;
        playerObject.GetComponentInChildren<Mouselook>().enabled = true;
        playerObject.GetComponentInChildren<Flashlight>().enabled = true;
    }

}

