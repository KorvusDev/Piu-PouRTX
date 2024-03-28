using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    public GameObject English;
    public GameObject Spanish;
    public GameObject Catalan;
    public GameObject Portuguese;
    public GameObject French;
    public GameObject Italian;
    //public GameObject German;

    void FixedUpdate()
    {
        if (Languages.sCurrentLanguage == "English") {English.SetActive(true);} else {English.SetActive(false);}
        if (Languages.sCurrentLanguage == "Español") {Spanish.SetActive(true);} else {Spanish.SetActive(false);}
        if (Languages.sCurrentLanguage == "Català") {Catalan.SetActive(true);} else {Catalan.SetActive(false);}
        if (Languages.sCurrentLanguage == "Português") {Portuguese.SetActive(true);} else {Portuguese.SetActive(false);}
        if (Languages.sCurrentLanguage == "Français") {French.SetActive(true);} else {French.SetActive(false);}
        if (Languages.sCurrentLanguage == "Italiano") {Italian.SetActive(true);} else {Italian.SetActive(false);}
        //if (Languages.sCurrentLanguage == "Deutsch") {German.SetActive(true);} else {German.SetActive(false);}
    }
}
