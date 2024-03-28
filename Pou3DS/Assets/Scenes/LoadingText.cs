using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingText : MonoBehaviour
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

    [Header ("Loading Time")]
    public float loadingTime;
    public float loadingTimer;

    [Header("Pablo")]
    public GameObject Pablo;
    public float rotation;

    void Start()
    {
        StartCoroutine(LanguageStart());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        loadingTime += Time.deltaTime;

        if (loadingTime >= loadingTimer)
        {
            if (loadingTime <= loadingTimer * 2)
            {
                if (Languages.sCurrentLanguage == "English") {Language.text = English + ".";}
                if (Languages.sCurrentLanguage == "Español") {Language.text = Spanish + ".";}
                if (Languages.sCurrentLanguage == "Català") {Language.text = Catalan + ".";}
                if (Languages.sCurrentLanguage == "Português") {Language.text = Portuguese + ".";}
                if (Languages.sCurrentLanguage == "Français") {Language.text = French + ".";}
                if (Languages.sCurrentLanguage == "Italiano") {Language.text = Italian + ".";}
            }
        }

        if (loadingTime >= loadingTimer * 2)
        {
            if (loadingTime <= loadingTimer * 3)
            {
                if (Languages.sCurrentLanguage == "English") {Language.text = English + "..";}
                if (Languages.sCurrentLanguage == "Español") {Language.text = Spanish + "..";}
                if (Languages.sCurrentLanguage == "Català") {Language.text = Catalan + "..";}
                if (Languages.sCurrentLanguage == "Português") {Language.text = Portuguese + "..";}
                if (Languages.sCurrentLanguage == "Français") {Language.text = French + "..";}
                if (Languages.sCurrentLanguage == "Italiano") {Language.text = Italian + "..";}
            }
        }

        if (loadingTime >= loadingTimer * 3)
        {
            if (loadingTime <= loadingTimer * 4)
            {
                if (Languages.sCurrentLanguage == "English") {Language.text = English + "...";}
                if (Languages.sCurrentLanguage == "Español") {Language.text = Spanish + "...";}
                if (Languages.sCurrentLanguage == "Català") {Language.text = Catalan + "...";}
                if (Languages.sCurrentLanguage == "Português") {Language.text = Portuguese + "...";}
                if (Languages.sCurrentLanguage == "Français") {Language.text = French + "...";}
                if (Languages.sCurrentLanguage == "Italiano") {Language.text = Italian + "...";}
            }
        }

        if (loadingTime >= loadingTimer * 4)
        {
            if (Languages.sCurrentLanguage == "English") {Language.text = English;}
            if (Languages.sCurrentLanguage == "Español") {Language.text = Spanish;}
            if (Languages.sCurrentLanguage == "Català") {Language.text = Catalan;}
            if (Languages.sCurrentLanguage == "Português") {Language.text = Portuguese;}
            if (Languages.sCurrentLanguage == "Français") {Language.text = French;}
            if (Languages.sCurrentLanguage == "Italiano") {Language.text = Italian;}

            loadingTime = 0;
        }
        
        //if (Languages.sCurrentLanguage == "Deutsch") {Language.text = German;}

        Pablo.transform.rotation = Quaternion.Euler(0, 0, rotation);

        rotation++;
    }

    IEnumerator LanguageStart()
    {
        yield return new WaitForSeconds(0.1f);
        if (Languages.sCurrentLanguage == "English") {Language.text = English;}
        if (Languages.sCurrentLanguage == "Español") {Language.text = Spanish;}
        if (Languages.sCurrentLanguage == "Català") {Language.text = Catalan;}
        if (Languages.sCurrentLanguage == "Português") {Language.text = Portuguese;}
        if (Languages.sCurrentLanguage == "Français") {Language.text = French;}
        if (Languages.sCurrentLanguage == "Italiano") {Language.text = Italian;}
    }
}
