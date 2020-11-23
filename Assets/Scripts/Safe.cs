using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Safe : InteractiveObject
{

    public GameObject playerobject;
    public GameObject PasswordUI;
    public GameObject SubmitButtonUI;


    public override void PlayerInteraction()
    {
        ShowPassword();
    }

    // Start is called before the first frame update
    void Start()
    {
        PasswordUI.SetActive(false);
        SubmitButtonUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPassword()
    {
        PasswordUI.SetActive(true);
        SubmitButtonUI.SetActive(true);
        playerobject.GetComponent<CharacterController>().enabled = false;
        playerobject.GetComponentInChildren<Mouselook>().enabled = false;
        playerobject.GetComponentInChildren<Flashlight>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DisablePassword()
    {
        PasswordUI.SetActive(false);
        SubmitButtonUI.SetActive(false);
        playerobject.GetComponent<CharacterController>().enabled = true;
        playerobject.GetComponentInChildren<Mouselook>().enabled = true;
        playerobject.GetComponentInChildren<Flashlight>().enabled = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
}
