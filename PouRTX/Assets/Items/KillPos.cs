using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPos : MonoBehaviour
{
    [Header ("Veneno Matador")]
    public float objectPosX;
    public float objectPosY;
    public GameObject canvas;
    //Min x:850 y:450 Max: x:1150 y:750
    [Header ("Límites X")]
    public float maxPosX;
    public float minPosX;

    [Header ("Límites Y")]
    public float maxPosY;
    public float minPosY;
    
    void Update()
    {
        objectPosX = gameObject.transform.position.x;
        objectPosY = gameObject.transform.position.y;

        if (objectPosX <= maxPosX && objectPosX >= minPosX)
        {
            if (objectPosY <= maxPosY && objectPosY >= minPosY)
            {
                Status.resetData = true;
            }
        }
    }
}
