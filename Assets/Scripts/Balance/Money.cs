using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float money;
    public static float sMoney;

    public Text currentMoney;

    void Start()
    {
        sMoney = PlayerPrefs.GetFloat("money");
    }

    void Update()
    {
        if (money != sMoney)
        {
            money = sMoney;
            PlayerPrefs.SetFloat("money", sMoney);
            currentMoney.text = sMoney.ToString("0");
        }

        if (money >= 9999999)
        {
            sMoney = 0;
        }
    }
}
