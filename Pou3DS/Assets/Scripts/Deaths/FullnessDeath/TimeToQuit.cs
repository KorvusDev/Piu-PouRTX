using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToQuit : MonoBehaviour
{
    public float timer;
    public float maxTime;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= maxTime) {Application.Quit();}
    }
}
