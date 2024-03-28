using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text coin;

    void Update()
    {
        coin.text = Money.sMoney.ToString("0");
    }
}
