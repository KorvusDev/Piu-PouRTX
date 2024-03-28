using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyObjectMovement : MonoBehaviour
{
    [Header ("Object")]
    public int TypeObject;
    
    [Header ("Values")]
    public float speed;
    public float start;
    public float end;
    public float maxDistance = -100;

    void Update()
    {
        if (FlappyPou.sIsDeath == false)
        {
            if (!InGameMenus.sIsInPause)
            {
                if (transform.position.x >= maxDistance)
                {
                    transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

                    if (transform.position.x <= end)
                    {
                        if (TypeObject == 1)
                        {
                            transform.position = new Vector2(start, transform.position.y);
                        }
                    }
                }
            }
        }
    }
}
