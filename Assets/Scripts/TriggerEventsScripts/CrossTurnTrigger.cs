using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTurnTrigger : MonoBehaviour
{
    public CrossTurn CT;
    public CrossTurn CT1;
    public CrossTurn CT2;
    public CrossTurn CT3;
    public CrossTurn CT4;
    public CrossTurn CT5;
    public CrossTurn CT6;
    public CrossTurn CT7;
    public CrossTurn CT8;
    public CrossTurn CT9;


    public GameObject Crosses;

    public GameObject Blood;


    void Start()
    {

        Blood.SetActive(false);
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CT.TurnCross();
            CT1.TurnCross();
            CT2.TurnCross();
            CT3.TurnCross();
            CT4.TurnCross();
            CT5.TurnCross();
            CT6.TurnCross();
            CT7.TurnCross();
            CT8.TurnCross();
            CT9.TurnCross();

            StartCoroutine(BloodReveal());
        }

    }


    IEnumerator BloodReveal()
    {
        yield return new WaitForSeconds(3);
        Blood.SetActive(true);
        Destroy(gameObject);
    }
   
    
}
