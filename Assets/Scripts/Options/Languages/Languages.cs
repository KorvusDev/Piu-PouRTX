using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Languages : MonoBehaviour
{
    [Header("Current Language")]
    public string currentLanguage;
    public static string sCurrentLanguage;

    [Header("Language")]
    public float language;
    public float staticLanguage;
    public static float sLanguage;

    [Header("Button")]
    public Button Next;
    public Button Previous;

    void Start()
    {
        language = PlayerPrefs.GetFloat("currentLanguage");
    }

    void Update()
    {
        if (staticLanguage != language)
        {
            PlayerPrefs.SetFloat("currentLanguage", language);
            sLanguage = language;
            staticLanguage = sLanguage;
        }

        if (sCurrentLanguage != currentLanguage) {sCurrentLanguage = currentLanguage;}

        if (language == 0) {currentLanguage = "English"; Previous.interactable = false;}
        if (language == 1) {currentLanguage = "Español";}
        if (language == 2) {currentLanguage = "Català";}
        if (language == 3) {currentLanguage = "Português";}
        if (language == 4) {currentLanguage = "Français";}
        if (language == 5) {currentLanguage = "Italiano"; Next.interactable = false;}
        //if (language == 6) {currentLanguage = "Deutsch"; Next.interactable = false;}

        if (language != 0) {Previous.interactable = true;}
        if (language != 5) {Next.interactable = true;}
    }

    public void NextLanguage()
    {
        language++;
    }

    public void PreviousLanguage()
    {
        language--;
    }
}
