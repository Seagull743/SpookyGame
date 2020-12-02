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
    private float timer;
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

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
        {
            Debug.Log("1");
            timer = 0f;
        }
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
