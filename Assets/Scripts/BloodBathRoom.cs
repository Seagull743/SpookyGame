using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Blood;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Blood.SetActive(false);
    }

    public void RevealBlood()
    {
        Blood.SetActive(true);
    }
}
