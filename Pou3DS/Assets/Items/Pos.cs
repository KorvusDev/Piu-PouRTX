using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos : MonoBehaviour
{
    public Vector2 position;

    void Update()
    {
        position = gameObject.transform.position;
    }
}
