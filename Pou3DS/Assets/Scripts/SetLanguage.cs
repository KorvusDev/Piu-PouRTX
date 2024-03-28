using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLanguage : MonoBehaviour
{
    [Header("Text")]
    public Text Language;

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
        if (Languages.sCurrentLanguage == "English") {Language.text = English;}
        if (Languages.sCurrentLanguage == "Español") {Language.text = Spanish;}
        if (Languages.sCurrentLanguage == "Català") {Language.text = Catalan;}
        if (Languages.sCurrentLanguage == "Português") {Language.text = Portuguese;}
        if (Languages.sCurrentLanguage == "Français") {Language.text = French;}
        if (Languages.sCurrentLanguage == "Italiano") {Language.text = Italian;}
        //if (Languages.sCurrentLanguage == "Deutsch") {Language.text = German;}
    }
}
