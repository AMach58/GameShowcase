using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    private PlayerMovements thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public int keys = 0;

    public bool doorOpen, waitingToOpen;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMovements>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitingToOpen)
        {
            if(Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) <0.1f)
            {
                waitingToOpen = false;

                doorOpen = true; 

                theSR.sprite = doorOpenSprite;
                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;

                keys++;

                
            }
        }


        /*
        if(doorOpen && Vector2.Distance(thePlayer.transform.position, transform.position) < 1f && Input.GetAxis("Vertical") > 0.01f)
        {
            
            SceneManager.LoadScene("MainMenu");
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToOpen = true;
            }
            if (keys == 3)
            {
                SceneManager.LoadScene("Win");
            }
        }

    }
}
