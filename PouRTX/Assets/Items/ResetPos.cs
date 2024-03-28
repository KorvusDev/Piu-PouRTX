using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    [Header ("Move Pos & Reset")]
    public GameObject obj;
    bool actived;
    public Vector2 latePos;
    public Vector2 currentPos;
    public float timer;

    [Header ("Reset Pos")]
    public Vector2 reset;
    public GameObject obj2;

    void Start() 
    {
        actived = true;
    }

    void Update()
    {
        currentPos = obj.transform.position;

        if (currentPos == latePos)
        {
            if (currentPos != reset)
            {
                if (!Input.GetKey("mouse 0") && !Input.GetKey("mouse 1") && !Input.GetKey("mouse 2"))
                {
                    timer += Time.deltaTime;
                }
            }
        }

        else
        {
            timer = 0;
            latePos = currentPos;
        }

        if (timer >= 0.1)
        {
            obj.transform.position = reset;
            actived = false;

            if (!Input.GetKey("mouse 0") && !Input.GetKey("mouse 1") && !Input.GetKey("mouse 2"))
            {
                timer = 0;
            }
        }


        else 
        {
            if (!Input.GetKey("mouse 0") && !Input.GetKey("mouse 1") && !Input.GetKey("mouse 2"))
            {
                actived = true;
            }
        }

        obj.SetActive(actived);
        obj2.SetActive(!actived);
    }
}
