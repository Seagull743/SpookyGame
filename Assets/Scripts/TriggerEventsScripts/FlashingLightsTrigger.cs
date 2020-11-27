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
            StartCoroutine(StartEventLaterOn());          
        }
    }


    IEnumerator StartEventLaterOn()
    {
        yield return new WaitForSeconds(7);
        TL.StartLightEvent();
        Destroy(gameObject);
    }


    

}
