using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTurnTrigger : MonoBehaviour
{
    public CrossTurn CT;
    public CrossTurn Cross1;
    public CrossTurn Cross2;
    public CrossTurn Cross3;
   
    public GameObject Crosses;

    public GameObject Blood;


    void Start()
    {
        Blood.SetActive(false);
    }

    public void RevealBlood()
    {
        Blood.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CT.TurnCross();
            Cross1.TurnCross();
            Cross2.TurnCross();
            Cross3.TurnCross();
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
