using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoWriter : MonoBehaviour
{
    [Header ("Text")]
    public Text texto;
    
    [Header ("Languages")]
    public string English;
    public string Spanish;
    public string Catalan;
    public string Portuguese;
    public string French;
    public string Italian;
    
    [Header ("Next Text")]
    public float MaxTime;
    public float MinTime;

    public GameObject NextText;
    public GameObject ThisText;

    public GameObject NextArrow;

    void Start()
    {
        StartCoroutine(Reloj());
        NextArrow.SetActive(false);
    }

    IEnumerator Reloj()
    {
        #region English
        if (Languages.sCurrentLanguage == "English")
        {
            foreach (char caracter in English)
            {
                texto.text = texto.text + caracter;
                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion
        #region Spanish
        if (Languages.sCurrentLanguage == "Español")
        {
            foreach (char caracter in Spanish)
            {
                texto.text = texto.text + caracter;
                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion
        #region Catalan
        if (Languages.sCurrentLanguage == "Català")
        {
            foreach (char caracter in Catalan)
            {
                texto.text = texto.text + caracter;
                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion
        #region Portuguese
        if (Languages.sCurrentLanguage == "Português")
        {
            foreach (char caracter in Portuguese)
            {
                texto.text = texto.text + caracter;
                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion
        #region French
        if (Languages.sCurrentLanguage == "Français")
        {
            foreach (char caracter in French)
            {
                texto.text = texto.text + caracter;
                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion
        #region Italian
        if (Languages.sCurrentLanguage == "Italiano")
        {
            foreach (char caracter in Italian)
            {
                texto.text = texto.text + caracter;
                if (caracter.ToString() == ",") {yield return new WaitForSeconds(0.2f);}
                if (caracter.ToString() == ";") {yield return new WaitForSeconds(0.3f);}
                if (caracter.ToString() == "." || caracter.ToString() == "!") {yield return new WaitForSeconds(0.4f);}

                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion
    }

    void Update() 
    {
        MinTime += Time.deltaTime;

        if (MaxTime <= MinTime)
        {
            NextArrow.SetActive(true);
            if (Input.anyKey)
            {
                Instantiate(NextText);
                Destroy(ThisText);
            }
        }
    }
}
