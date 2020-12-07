using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public GameObject pauseCanvas;
    bool isPaused;

    public void Start()
    {
        pauseCanvas.SetActive(false);
    }





    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("pause");
            
            if (!isPaused)
            {
                Time.timeScale = 0f;
                isPaused = true;
                pauseCanvas.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                isPaused = false;
                pauseCanvas.SetActive(false);
            }

        }
    }
}
