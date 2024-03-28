using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelector : MonoBehaviour
{
    public void LoadGame(string Game)
    {
        PlayerPrefs.SetFloat("Energy", Status.sEnergyLevel);
        PlayerPrefs.SetFloat("Fullness", Status.sFullnessLevel);
        PlayerPrefs.SetFloat("Health", Status.sHealthLevel);
        PlayerPrefs.SetFloat("Fun", Status.sFunLevel);
        
        SceneManager.LoadScene(Game);
    }
}
