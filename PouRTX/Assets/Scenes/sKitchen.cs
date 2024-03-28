using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sKitchen : MonoBehaviour
{
    public float screenRes;
    public float currentScene;

    void Start()
    {
        screenRes = PlayerPrefs.GetFloat("screenRes");
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1f); 
        if (screenRes == 1 && currentScene != 1) {SceneManager.LoadScene("KitchenB");}
        if (screenRes == 0 && currentScene != 0) {SceneManager.LoadScene("KitchenA");}
    }

    public void Change(int ID) {screenRes = ID; StartCoroutine(saveRes());}
    IEnumerator saveRes() 
    {
        //PlayerPrefs.SetFloat("Energy", Status.sEnergyLevel);
        //PlayerPrefs.SetFloat("Fullness", Status.sFullnessLevel);
        //PlayerPrefs.SetFloat("Health", Status.sHealthLevel);
        //PlayerPrefs.SetFloat("Fun", Status.sFunLevel);

        PlayerPrefs.SetFloat("screenRes", screenRes); 
        yield return new WaitForSeconds(0.1f); 

        if (screenRes == 1) 
        {
            SceneManager.LoadScene("KitchenB");
        }

        if (screenRes == 0) 
        {
            SceneManager.LoadScene("KitchenA");
        }
    }
}
