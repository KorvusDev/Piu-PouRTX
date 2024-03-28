using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreEnergy : MonoBehaviour
{
    public GameObject lightOn;
    public GameObject lightOff;
    public GameObject blackScreen;

    public static bool sIsSleeping;
    public bool isSleeping;

    void Start()
    {
        sIsSleeping = false;
    }

    void Update()
    {
        if (sIsSleeping != isSleeping)
        {
            sIsSleeping = isSleeping;
        }

        lightOn.SetActive(!isSleeping);
        lightOff.SetActive(isSleeping);
        blackScreen.SetActive(isSleeping);
    }

    public void changeLight()
    {
        isSleeping = !isSleeping;
    }
}
