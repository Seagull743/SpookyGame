using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public static GM instance;
    [SerializeField] private GameObject interactcross;
    [SerializeField] private GameObject normalcross;
    public GameObject player;
    public GameObject InstructionText;

     void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        InstructionText.SetActive(false);
    }

    void Start()
    {
        StartCoroutine(TextSeconds());
    }


    IEnumerator TextSeconds()
    {
        yield return new WaitForSeconds(1);
        InstructionText.SetActive(true);
        yield return new WaitForSeconds(3);
        InstructionText.SetActive(false);
    }

    public void InteractCross()
    {
        
        interactcross.SetActive(true);
        normalcross.SetActive(false);

       
    }

    public void Normalcross()
    {
        interactcross.SetActive(false);
        normalcross.SetActive(true);
    }



    
}
