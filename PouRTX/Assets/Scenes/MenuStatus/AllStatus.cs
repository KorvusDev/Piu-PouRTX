using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllStatus : MonoBehaviour
{
    [Header ("Status Float")]
    public float Energy;
    public float Fullness;
    public float Health;
    public float Fun;

    [Header ("Status Texts")]
    public Text tEnergy;
    public Text tFullness;
    public Text tHealth;
    public Text tFun;

    [Header ("Time Strings")]
    public string currentTime;
    public string lastTime;
    public string elapsedTime;

    [Header ("Time Texts")]
    public Text tCurrentTime;
    public Text tLastTime;
    public Text tElapsedTime;

    void Update()
    {
        Energy = Status.sEnergyLevel;
        Fullness = Status.sFullnessLevel;
        Health = Status.sHealthLevel;
        Fun = Status.sFunLevel;

        tEnergy.text = "Energy: " + Energy.ToString("0"); 
        tFullness.text = "Fullness: " + Fullness.ToString("0"); 
        tHealth.text = "Health: " + Health.ToString("0"); 
        tFun.text = "Fun: " + Fun.ToString("0"); 

        currentTime = Times.sCurrentTime;
        lastTime = Times.sLastTime;
        elapsedTime = Times.sElapsedTime;

        tCurrentTime.text = "ct: " + currentTime;
        tLastTime.text = "lt: " + lastTime;
        tElapsedTime.text = "et: " + elapsedTime;
    }
}
