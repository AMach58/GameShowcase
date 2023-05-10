using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuS : MonoBehaviour
{

    public static bool Paused = false;
    public GameObject PauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            if(Paused)
            {
                Play();
            }
            else
            {
                stop();
            }
        }
    }

    void stop()
    {
        PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        Paused = true;
        Cursor.visible = true;
    }
    
    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
            Time.timeScale = 01f;
        Paused = false;
        Cursor.visible = false;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
    }
   
}