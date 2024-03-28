using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveKitchen : MonoBehaviour
{
    public GameObject KitchenA;
    public GameObject KitchenB;
    public GameObject KitchenC;

    public static bool sIsOn;
    public bool isOn;

    void Start()
    {
        sIsOn = true;
    }

    void Update()
    {
        if (isOn != sIsOn)
        {
            KitchenA.SetActive(sIsOn);
            KitchenB.SetActive(sIsOn);
            KitchenC.SetActive(sIsOn);
            isOn = sIsOn;
        }
    }
}
