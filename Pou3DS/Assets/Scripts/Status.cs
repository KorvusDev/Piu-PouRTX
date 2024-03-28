using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    [Header ("FillImage")]
    public Image energy;
    public Image fullness;
    public Image health;
    public Image fun;

    public static float sEnergyLevel = 172800;
    public static float sFullnessLevel = 86400;
    public static float sHealthLevel = 172800;
    public static float sFunLevel = 604800;

    [Header ("Values")]
    public float energyLevel;
    public float fullnessLevel;
    public float healthLevel;
    public float funLevel;

    public bool isInFinal;
    public bool isSleeping;

    public static bool resetData;

    //[Header ("Negative Values")]
    //public float nEnergyLevel;
    //public float nFullnessLevel;
    //public float nHealthLevel;
    //public float nFunLevel;

    //public static float snEnergyLevel;
    //public static float snFullnessLevel;
    //public static float snHealthLevel;
    //public static float snFunLevel;

    [Header ("Final")]
    public GameObject[] deathFinal;

    //[Header ("Set String To <Modify>")]
    //public string Modify;

    IEnumerator Final(int Number)
    {
        yield return new WaitForSeconds(1f);
        FinalDetect.sIsInFinal = Number;
        isInFinal = true;
        if (Number == 1) {deathFinal[2].SetActive(true);} //{SceneManager.LoadScene("FullnessDeath");}
        if (Number == 2) {deathFinal[3].SetActive(true);} //{SceneManager.LoadScene("HealthDeath");}
        if (Number == 3) {deathFinal[4].SetActive(true);} //{SceneManager.LoadScene("FunDeath");}
        if (Number == 4) {deathFinal[5].SetActive(true);}
        yield return new WaitForSeconds(1f);
        if (Number != 0) {ActiveKitchen.sIsOn = false;}
    }

    void Start()
    {
        isInFinal = false;
        resetData = false;
        //StartCoroutine(ElapsedTime());
        StartCoroutine(StartIE());
    }

    //void Awake() 
    //{
        //sEnergyLevel = PlayerPrefs.GetFloat("Energy");
        //sFullnessLevel = PlayerPrefs.GetFloat("Fullness");
        //sHealthLevel = PlayerPrefs.GetFloat("Health");
        //sFunLevel = PlayerPrefs.GetFloat("Fun");
    //}

    IEnumerator StartIE()
    {
        yield return new WaitForSeconds(0.1f);
        sEnergyLevel = PlayerPrefs.GetFloat("Energy");
        sFullnessLevel = PlayerPrefs.GetFloat("Fullness");
        sHealthLevel = PlayerPrefs.GetFloat("Health");
        sFunLevel = PlayerPrefs.GetFloat("Fun");

        //nEnergyLevel = PlayerPrefs.GetFloat("nEnergy");
        //nFullnessLevel = PlayerPrefs.GetFloat("nFullness");
        //nHealthLevel = PlayerPrefs.GetFloat("nHealth");
        //nFunLevel = PlayerPrefs.GetFloat("nFun");

        yield return new WaitForSeconds(0.4f);
        StartCoroutine(DataUpdateIE());
    }

    #region Change Data
    IEnumerator DataUpdateIE()
    {
        if (!isInFinal)
        {
            if (sEnergyLevel != energyLevel)
            {
                //if (Modify != "Modify") {energyLevel = sEnergyLevel;}      
                //else {sEnergyLevel = energyLevel;}      
                energyLevel = sEnergyLevel;
                PlayerPrefs.SetFloat("Energy", energyLevel);
            }        

            if (sFullnessLevel != fullnessLevel)
            {
                //if (Modify != "Modify") {fullnessLevel = sFullnessLevel;}
                //else {sFullnessLevel = fullnessLevel;}
                fullnessLevel = sFullnessLevel;
                PlayerPrefs.SetFloat("Fullness", fullnessLevel);
            }

            if (sHealthLevel != healthLevel)
            {
                //if (Modify != "Modify") {healthLevel = sHealthLevel;}
                //else {sHealthLevel = healthLevel;}
                healthLevel = sHealthLevel;
                PlayerPrefs.SetFloat("Health", healthLevel);
            }

            if (sFunLevel != funLevel)
            {
                //if (Modify != "Modify") {funLevel = sFunLevel;}
                //else {sFunLevel = funLevel;}
                funLevel = sFunLevel;
                PlayerPrefs.SetFloat("Fun", funLevel);
            }

            //sEnergyLevel -= 25;
            //sFullnessLevel -= 25;
            //sHealthLevel -= 25;
            //sFunLevel -= 1;
        }

        yield return new WaitForSeconds(0.2f);
        StartCoroutine(DataUpdateIE());
    }
    #endregion

    void FixedUpdate()
    {
        isSleeping = MoreEnergy.sIsSleeping;
        
        if (!isInFinal)
        {
            //if (Modify != "Modify")
            //{
                if (!isSleeping)
                {
                    sEnergyLevel -= Time.deltaTime * 25 * 3 * 10;
                    sFullnessLevel -= Time.deltaTime * 25 * 3 * 10;
                    sHealthLevel -= Time.deltaTime * 25 * 3 * 10;
                    sFunLevel -= Time.deltaTime * 3 * 10;

                    //nEnergyLevel -= Time.deltaTime * 25;
                    //nFullnessLevel -= Time.deltaTime * 25;
                    //nHealthLevel -= Time.deltaTime * 25;
                    //nFunLevel -= Time.deltaTime;
                }

                else
                {
                    sEnergyLevel += Time.deltaTime * 25 * (3 * 6);
                    sFullnessLevel -= Time.deltaTime * 25 / (3 * 6);
                    sHealthLevel -= Time.deltaTime * 25 / (3 * 6);
                    sFunLevel -= Time.deltaTime;
                }
            //}
        }

        if (resetData) {StartCoroutine(Final(4));}

        if (sFullnessLevel <= -86401) {StartCoroutine(Final(1));}
        if (sHealthLevel <= -172801) {StartCoroutine(Final(2));}
        if (sFunLevel <= -86401) {StartCoroutine(Final(3));}

        #region Limit Energy
        if (sEnergyLevel >= 172801) {sEnergyLevel = 172800; energyLevel = 172800;}
        if (sFullnessLevel >= 86401) {sFullnessLevel = 86400; fullnessLevel = 86400;}
        if (sHealthLevel >= 172801) {sHealthLevel = 172800; healthLevel = 172800;}
        if (sFunLevel >= 86401) {sFunLevel = 86400; funLevel = 86400;}

        if (sEnergyLevel <= -1) {sEnergyLevel = 0; energyLevel = 0;}
        //if (sFullnessLevel <= -1) {sFullnessLevel = 0; fullnessLevel = 0;}
        //if (sHealthLevel <= -1) {sHealthLevel = 0; healthLevel = 0;}
        //if (sFunLevel <= -1) {sFunLevel = 0; funLevel = 0;}
        #endregion

        #region Change Amount
        energy.fillAmount = sEnergyLevel / 172800;
        fullness.fillAmount = sFullnessLevel / 86400;
        health.fillAmount = sHealthLevel / 172800;
        fun.fillAmount = sFunLevel / 86400;
        #endregion

        //if (Modify != "Modify")
        //{
            //if (sEnergyLevel >= 1) {nEnergyLevel = sEnergyLevel;}
            //if (sFullnessLevel >= 1) {nFullnessLevel = sFullnessLevel;}
            //if (sHealthLevel >= 1) {nHealthLevel = sHealthLevel;}
            //if (sFunLevel >= 1) {nFunLevel = sFunLevel;}
        //}

        //if (snEnergyLevel != nEnergyLevel) {snEnergyLevel = nEnergyLevel; PlayerPrefs.SetFloat("nEnergy", nEnergyLevel);};
        //if (snFullnessLevel != nFullnessLevel) {snFullnessLevel = nFullnessLevel; PlayerPrefs.SetFloat("nFullness", nEnergyLevel);}
        //if (snHealthLevel != nHealthLevel) {snHealthLevel = nHealthLevel; PlayerPrefs.SetFloat("nHealth", nEnergyLevel);}
        //if (snFunLevel != sFunLevel) {snFunLevel = sFunLevel; PlayerPrefs.SetFloat("nFun", nEnergyLevel);}
    }

    //#region Substract Time Elapsed Since Last Session
    //IEnumerator ElapsedTime()
    //{
        //yield return new WaitForSeconds(0.1f);
        //if (Modify != "Modify") 
        //{
            //yield return new WaitForSeconds(0.2f);
            //sEnergyLevel -= Times.totalSeconds;
            //sFullnessLevel -= Times.totalSeconds;
            //sHealthLevel -= Times.totalSeconds;
            //sFunLevel -= Times.totalSeconds * 2;
        //}

        ////nEnergyLevel -= Times.totalSeconds;
        ////nFullnessLevel -= Times.totalSeconds;
        ////nHealthLevel -= Times.totalSeconds;
        ////nFunLevel -= Times.totalSeconds;
    //}
    //#endregion
}
