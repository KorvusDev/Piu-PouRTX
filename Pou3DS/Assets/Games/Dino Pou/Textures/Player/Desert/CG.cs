using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG : MonoBehaviour
{

    public static bool isDesGrounded;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        isDesGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isDesGrounded = false;
    }
}