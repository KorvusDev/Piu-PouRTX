using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sKitchen1 : MonoBehaviour
{
    public float screenRes;

    public GameObject[] kitchens;

    void Start()
    {
        screenRes = PlayerPrefs.GetFloat("screenRes");
        StartCoroutine(LoadScene());
    }

    void OnEnable()
    {
        if (screenRes == PlayerPrefs.GetFloat("screenRes"))
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.01f); 
        if (screenRes == 1) {kitchens[1].SetActive(true); kitchens[0].SetActive(false);}
        if (screenRes == 0) {kitchens[0].SetActive(true); kitchens[1].SetActive(false);}
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
            kitchens[1].SetActive(true); kitchens[0].SetActive(false);
        }

        if (screenRes == 0) 
        {
            kitchens[0].SetActive(true); kitchens[1].SetActive(false);
        }
    }
}
