using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMoney : MonoBehaviour
{
    public float clicks;
    public float rClicks;

    void Start()
    {
        rClicks = Random.Range(5, 100);
    }

    void Update()
    {
        if (clicks >= rClicks)
        {        
            rClicks = Random.Range(5, 100);
            Money.sMoney++;
            clicks = 0;
        }

        if (Input.GetKeyDown("mouse 0"))
        {
            clicks++;
        }
    }
}
