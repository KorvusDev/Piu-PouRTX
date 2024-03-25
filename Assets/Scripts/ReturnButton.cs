using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public GameObject thisMenu;
    public GameObject mainMenu;

    public void Return(int NumberMenu)
    {
        mainMenu.SetActive(true);
        thisMenu.SetActive(false);

        if (NumberMenu == 1)
        {
            Buttons.isInSettings = false;
        }
    }
}
