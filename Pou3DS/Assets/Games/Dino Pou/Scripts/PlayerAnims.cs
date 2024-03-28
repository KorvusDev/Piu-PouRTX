using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour
{
    public Rigidbody2D rb2D;

    public Rigidbody2D rb22D;

    bool isJumping;

    public Animator animator;

    public GameObject Dino;

    public GameObject DinoCouch;

    AudioSource jump;

    public static bool isResetting;
    public static bool isResetting1;
    float resetTime;

    public Vector2 startPos;

    public float clickTime;

    void Start()
    {
        startPos = gameObject.transform.position;

        DinoCouch.SetActive(false);
        rb2D = GetComponent<Rigidbody2D>();
        rb22D = GetComponent<Rigidbody2D>();
        isJumping = false;
        CG.isDesGrounded = true;

        jump = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        resetTime += Time.deltaTime;

        if (isResetting || isResetting1) 
        {
            gameObject.transform.position = startPos; resetTime = 0;
            animator.SetBool("Jump", false);
            isJumping = false;
            CG.isDesGrounded = true;
        }

        if (Input.GetKey("mouse 0") && isJumping == false && Death.isDeath == false || Input.GetKey("up") && isJumping == false && Death.isDeath == false || Input.GetKey("w") && isJumping == false && Death.isDeath == false)
        {
            jump.Play();
            rb2D.velocity = new Vector3(0, 10, 0);
            rb22D.velocity = new Vector3(0, 10, 0);
            isJumping = true;
            animator.SetBool("Jump", true);
            Dino.SetActive(true);
            DinoCouch.SetActive(false);

            clickTime = 0;
        }

        if (!Input.GetKey("mouse 0"))
        {
            clickTime += Time.deltaTime;
        }

        else if (Input.GetKey("mouse 0") && isJumping == true && Death.isDeath == false || Input.GetKey("down") && isJumping == true && Death.isDeath == false || Input.GetKey("s") && isJumping == true && Death.isDeath == false)
        {
            if (gameObject.transform.position.y >= -0.5)
            {
                if (clickTime >= 0.03)
                {
                    rb2D.velocity = new Vector3(0, -8, 0);
                    rb22D.velocity = new Vector3(0, -8, 0);
                }
            }
        }

        //if (Input.GetKey("mouse 1") && isJumping == false && Death.isDeath == false || Input.GetKey("down") && isJumping == false && Death.isDeath == false || Input.GetKey("s") && isJumping == false && Death.isDeath == false)
        //{
            //DinoCouch.SetActive(true);
            //Dino.SetActive(false);
        //}

        //else
        //{
            //Dino.SetActive(true);
            //DinoCouch.SetActive(false);
        //}

        //if (Death.isDeath == true) {if(isJumping == true)
        //{
            //rb2D.velocity = new Vector3(2, -20, 0);
            //isJumping = true;
        //}}

        //else
        //{
            //Death.isDeath = false;
            //animator.SetBool("Death", false);
        //}

        //if (Death.isDeath == true && isJumping == false)
        //{
            //animator.SetBool("Death", true);
            //rb2D.velocity = new Vector3(2, 0, 0);
            //isJumping = false;
            //animator.SetBool("Jump", false);
            //Dino.SetActive(true);
            //DinoCouch.SetActive(false);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Desert")
        {
            isJumping = false;
            animator.SetBool("Jump", false);
            //if (Death.isDeath == true)
            //{
                //animator.SetBool("Death", true);
            //}
        }

        else
        {
            isJumping = true;
            animator.SetBool("Jump", true);
            Dino.SetActive(true);
            //DinoCouch.SetActive(false);
        }
    }
}
