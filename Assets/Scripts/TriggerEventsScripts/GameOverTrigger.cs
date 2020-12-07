using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public GM gm;
    public GameObject player;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.GetComponentInChildren<Mouselook>().enabled = false;
            player.GetComponentInChildren<Flashlight>().enabled = false;
            player.GetComponent<PlayerFootStepsSound>().enabled = false;
            StartCoroutine(YouWin());
        }
    }

    IEnumerator YouWin()
    {
        yield return new WaitForSeconds(2);
        gm.Youwin();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("StartScreen");
    }
}



