using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLanguageWithValue : MonoBehaviour
{
    [Header("Text")]
    public static string Language;

    [Header("Languages")]
    public string English;
    public string Spanish;
    public string Catalan;
    public string Portuguese;
    public string French;
    public string Italian;
    //public string German;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Languages.sCurrentLanguage == "English") {Language = English;}
        if (Languages.sCurrentLanguage == "Español") {Language = Spanish;}
        if (Languages.sCurrentLanguage == "Català") {Language = Catalan;}
        if (Languages.sCurrentLanguage == "Português") {Language = Portuguese;}
        if (Languages.sCurrentLanguage == "Français") {Language = French;}
        if (Languages.sCurrentLanguage == "Italiano") {Language = Italian;}
        //if (Languages.sCurrentLanguage == "Deutsch") {Language = German;}
    }
}
