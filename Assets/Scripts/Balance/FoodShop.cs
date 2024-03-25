using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShop : MonoBehaviour
{
    [Header ("Error")]
    public GameObject Error;

    [Header ("Bought")]
    public float balance;

    public string Name;

    public void BuyObject()
    {
        if (Money.sMoney <= balance - 1)
        {
            Instantiate(Error);
        }
        else
        {
            Money.sMoney -= balance;

            if (Name == "Manzana") {Fruits.sA++;}
            if (Name == "Banana") {Fruits.sB++;}
            if (Name == "Pera") {Fruits.sP++;}
            if (Name == "Naranja") {Fruits.sN++;}
            if (Name == "Uva") {Fruits.sU++;}
            if (Name == "Cereza") {Fruits.sC++;}
            if (Name == "Pez") {Fruits.sPz++;}
            if (Name == "Helado") {Fruits.sH++;}
            if (Name == "Chocolate") {Fruits.sCh++;}
        }
    }
}
