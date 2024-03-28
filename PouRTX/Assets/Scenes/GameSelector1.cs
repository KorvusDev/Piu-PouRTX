using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelector1 : MonoBehaviour
{
    public GameObject[] games;
    public GameObject Error;

    public void LoadGame(int gameID)
    {
        if (Status.sEnergyLevel >= Status.sEnergyLevel / 5)
        {
            //PlayerPrefs.SetFloat("Energy", Status.sEnergyLevel);
            //PlayerPrefs.SetFloat("Fullness", Status.sFullnessLevel);
            //PlayerPrefs.SetFloat("Health", Status.sHealthLevel);
            //PlayerPrefs.SetFloat("Fun", Status.sFunLevel);
            
            //SceneManager.LoadScene(Game);

            //games[gameID].SetActive(true);
            Instantiate(games[gameID]);
            ActiveKitchen.sIsOn = false;
        }

        else
        {
            Instantiate(Error);
        }
    }
}
