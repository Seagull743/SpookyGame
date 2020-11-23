using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    public static GM instance;
    [SerializeField] private GameObject interactcross;
    [SerializeField] private GameObject normalcross;
    public GameObject player;
   

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
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
