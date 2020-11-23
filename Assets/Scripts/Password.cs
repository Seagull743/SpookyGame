using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Password : MonoBehaviour
{

    private string password = "328166";
    public InputField UserInput;
    public string USERINPUT;
    public Safe safe;
    

    public void CheckPassword()
    {
        USERINPUT = UserInput.text;

        if(USERINPUT != null)
        {
            if(USERINPUT == password)
            {
                safe.DisablePassword();


                //Then play the animation of the safe etc...
            }
            else
            {
             //Remove Text
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
