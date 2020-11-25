using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public GameObject DeadScreen;
    public GameObject RedScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        DeadScreen.SetActive(false);
        RedScreen.SetActive(false);
    }

    public void playerdeath()
    {
        anim.SetBool("death", true);
        RedScreen.SetActive(true);
        player.GetComponentInChildren<Mouselook>().enabled = false;
        player.GetComponentInChildren<Flashlight>().enabled = false;
        StartCoroutine(Deathscreenwaittime());

    }


 IEnumerator Deathscreenwaittime()
    {  
        yield return new WaitForSeconds(2);
        RedScreen.SetActive(false);
        DeadScreen.SetActive(true);
    }
}
