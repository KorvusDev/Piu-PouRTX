using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour
{
    public float _TimeScale;

    public string Game;

    void Update()
    {
        _TimeScale = Time.timeScale;

        if (!InGameMenus1.sIsInPause)
        {
            if (_TimeScale <= 0.5)
            {
                if (Game == "Flappy Pou")
                {
                    if (!FlappyPou.sIsDeath)
                    {
                        Time.timeScale = 1f;
                    }
                }
            }
        }
    }
}
