using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFPS : MonoBehaviour
{
    public int currentNumber;
    public int FPS;
    public int sFPS;

    public Text FPSText;

    //FPS Controller
    public Button fpsMinus;
    public Button fpsPlus;

    public GameObject Unlimited;
    public GameObject Limited;

    void Start()
    {
        currentNumber = PlayerPrefs.GetInt("fpsvalue");
        Application.targetFrameRate = FPS;
    }

    void Update()
    {
        if (sFPS != FPS)
        {
            PlayerPrefs.SetInt("fpsvalue", currentNumber);
            sFPS = FPS;
        }

        Application.targetFrameRate = FPS;

        if (FPS == 0)
        {
            FPS = 60;
        }

        if (FPS >= 0)
        {
            FPSText.text = FPS.ToString("00") + " FPS";
            Limited.SetActive(true);
            Unlimited.SetActive(false);
        }

        else
        {
            Limited.SetActive(false);
            Unlimited.SetActive(true);
            FPSText.text = "144 FPS";
        }

        if (currentNumber == 0) {currentNumber = 3;}
        if (currentNumber == 1) {FPS = 24;}
        if (currentNumber == 2) {FPS = 30;}
        if (currentNumber == 3) {FPS = 60;}
        if (currentNumber == 4) {FPS = 90;}
        if (currentNumber == 5) {FPS = 120;}
        if (currentNumber == 6) {FPS = 144;}
        if (currentNumber == 7) {FPS = -1;}

        if (FPS == 24) {fpsMinus.interactable = false;}
        else {fpsMinus.interactable = true;}

        if (FPS == -1) {fpsPlus.interactable = false;}
        else {fpsPlus.interactable = true;}
    }

    public void FPSMinus()
    {
        currentNumber--;
        //if (FPS == -1) {FPS = 144;}
        //if (FPS == 144) {FPS = 120;}
        //if (FPS == 120) {FPS = 90;}
        //if (FPS == 90) {FPS = 60;}
        //if (FPS == 60) {FPS = 30;}
        //if (FPS == 30) {FPS = 24;}
    }

    public void FPSPlus()
    {
        currentNumber++;
        //if (FPS == 144) {FPS = -1;}
        //if (FPS == 120) {FPS = 144;}
        //if (FPS == 90) {FPS = 120;}
        //if (FPS == 60) {FPS = 90;}
        //if (FPS == 30) {FPS = 60;}
        //if (FPS == 24) {FPS = 30;}
    }
}