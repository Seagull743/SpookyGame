using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Note : InteractiveObject
{

    public GameObject playerObject;
    public GM gm;
    public Image noteImage;
    public GameObject Hidenotbutton;

   // public AudioSource pickupSound;



    // Start is called before the first frame update
    void Start()
    {
        Hidenotbutton.SetActive(false);
        noteImage.enabled = false;
        // noteImage.SetActive(false);
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
        noteImage.enabled = true;
        Hidenotbutton.SetActive(true);
        //noteImage.SetActive(true);
        playerObject.GetComponent<CharacterController>().enabled = false;
        playerObject.GetComponentInChildren<Mouselook>().enabled = false;
        playerObject.GetComponentInChildren<Flashlight>().enabled = false;
        gm.GetComponent<GM>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //pickupSound.Play();
    }

    public void HideNoteImage()
    {

        Hidenotbutton.SetActive(false);
        noteImage.enabled = false;
        //noteImage.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gm.GetComponent<GM>().enabled = true;
        playerObject.GetComponent<CharacterController>().enabled = true;
        playerObject.GetComponentInChildren<Mouselook>().enabled = true;
        playerObject.GetComponentInChildren<Flashlight>().enabled = true;
    }

}

