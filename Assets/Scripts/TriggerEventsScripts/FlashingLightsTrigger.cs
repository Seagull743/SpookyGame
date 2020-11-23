using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLightsTrigger : MonoBehaviour
{

    public TurnLight TL;
    public GameObject trigger;
  

    void Start()
    {
        
    }






    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine("StartEventLaterOn");           
        }
    }


    IEnumerator StartEventLaterOn()
    {
        yield return new WaitForSeconds(18);
        TL.StartCoroutine("FlashingLights");
        yield return new WaitForSeconds(20);
    }


    //Make a draw that the player can't open but it automatically gets open further into the game

}
