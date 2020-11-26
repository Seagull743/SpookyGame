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
        StartCoroutine(DeathFallAnimation());
        RedScreen.SetActive(true);
        player.GetComponentInChildren<Mouselook>().enabled = false;
        player.GetComponentInChildren<Flashlight>().enabled = false;
        StartCoroutine(Deathscreenwaittime());

    }

IEnumerator DeathFallAnimation()
    {
        yield return new WaitForSeconds(4);
        anim.SetBool("death", true);
    }

 IEnumerator Deathscreenwaittime()
    {  
        yield return new WaitForSeconds(2);
        RedScreen.SetActive(false);
        DeadScreen.SetActive(true);
    }
}
