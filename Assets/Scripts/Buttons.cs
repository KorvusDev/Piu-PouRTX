using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject SettingsScreen;
    public GameObject UpperBar;
    public static bool isInSettings;
    public GameObject FoodShop;
    public static bool isInFoodShop;

    public GameObject Fridge;

    void Start() 
    {
        isInSettings = false;
        isInFoodShop = false;
    }

    void Update() 
    {
        SettingsScreen.SetActive(isInSettings);
        FoodShop.SetActive(isInFoodShop);
    }

    public void SettingsButton()
    {
        isInSettings = true;
    }

    public void ShopButton()
    {
        isInFoodShop = !isInFoodShop;
    }

    public void FridgeButton()
    {
        Instantiate(Fridge);
    }
}
