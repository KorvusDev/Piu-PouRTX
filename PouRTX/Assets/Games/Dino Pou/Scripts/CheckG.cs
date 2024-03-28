using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckG : MonoBehaviour
{

    public static bool isGrounded;

    public Rigidbody2D rb2D;

    bool isJumping;

    void start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isGrounded = true;
            rb2D.velocity = new Vector3(0, 30, 0);
        }

        else
        {
            isGrounded = false;
        }

        if (collision.gameObject.tag == "Water")
        {
            isJumping = false;
        }
        
        else
        {
            isJumping = true;
        }
    }

    void Update()
    {
        if (isJumping == true)
        {
            isGrounded = false;
        }
    }
}