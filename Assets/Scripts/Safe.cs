using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Safe : InteractiveObject
{

    public GameObject playerobject;
    public GameObject PasswordUI;
    public GameObject SubmitButtonUI;
    public GameObject exitUI;
    public Animator anim;

    public override void PlayerInteraction()
    {
        ShowPassword();
        //OpenSafe();
    }

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponentInChildren<Animator>();
        PasswordUI.SetActive(false);
        SubmitButtonUI.SetActive(false);
        exitUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSafe()
    {
        
        anim.SetTrigger("OpenSafe");
        
        
    }



    public void ShowPassword()
    {
        PasswordUI.SetActive(true);
        SubmitButtonUI.SetActive(true);
        exitUI.SetActive(true);
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
        exitUI.SetActive(false);
        playerobject.GetComponent<CharacterController>().enabled = true;
        playerobject.GetComponentInChildren<Mouselook>().enabled = true;
        playerobject.GetComponentInChildren<Flashlight>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
}
