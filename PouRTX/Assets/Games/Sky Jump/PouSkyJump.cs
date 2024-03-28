using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouSkyJump : MonoBehaviour
{
    [Header ("Controlador")]
    public float jumpForce;
    public float movement;
    public Rigidbody2D rb2D;

    [Header ("Otros parámetros")]
    public float time;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.CompareTag("Platform"))
        {
            StartCoroutine(Jump());
        }
    }

    IEnumerator Jump()
    {
        yield return new WaitForSeconds(time);
        rb2D.velocity = new Vector2(0, jumpForce);
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(movement, 0);
        }

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(-movement, 0);
        }
    }
}
