using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyMoney : MonoBehaviour
{
    [Header ("Balance")]
    public float balance;

    [Header ("Set String To <Modify>")]
    public string Modify;

    void Update()
    {
        if (Modify == "Modify")
        {
            if (balance <= 9999999)
            {
                Money.sMoney = balance;
            }
        }
    }
}
