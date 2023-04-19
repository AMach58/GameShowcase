using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlChange : MonoBehaviour
{
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    // When Character enter box collider
    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }

}
