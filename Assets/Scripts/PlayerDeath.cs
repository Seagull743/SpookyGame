using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public GameObject DeadScreen;
    public GameObject ghost;
    public AudioSource DeathSound;
    public StateController SC;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        DeadScreen.SetActive(false);
        
    }

    public void playerdeath()
    {
        SC.GetComponent<StateController>().enabled = false;
        ghost.SetActive(false);
        StartCoroutine(DeathAnimWait());
        
       
    }
IEnumerator DeathAnimWait()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("death", true);
        DeathSound.Play();
        StartCoroutine(Deathscreenwaittime());
    }

 IEnumerator Deathscreenwaittime()
    {  
        yield return new WaitForSeconds(3);
        DeadScreen.SetActive(true);
    }
}
