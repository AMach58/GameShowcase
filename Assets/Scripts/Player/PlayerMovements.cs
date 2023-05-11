using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool grounded;
    private Animator anim;

    private float dirX = 0f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            Jump();
        }

        UpdateAnimationUpdate();
    }
    private void UpdateAnimationUpdate()
    {
        if(dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector3(0, 10, 0);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Platform")
        {
            grounded = true;
        }
    }
}
