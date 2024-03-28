using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nevera : MonoBehaviour
{
    public GameObject Fridge;

    
    [HideInInspector] public Text tA;
    [HideInInspector] public GameObject gA;

    [HideInInspector] public Text tB;
    [HideInInspector] public GameObject gB;

    [HideInInspector] public Text tP;
    [HideInInspector] public GameObject gP;

    [HideInInspector] public Text tN;
    [HideInInspector] public GameObject gN;

    [HideInInspector] public Text tU;
    [HideInInspector] public GameObject gU;

    [HideInInspector] public Text tC;
    [HideInInspector] public GameObject gC;

    [HideInInspector] public Text tPz;
    [HideInInspector] public GameObject gPz;

    [HideInInspector] public Text tH;
    [HideInInspector] public GameObject gH;

    [HideInInspector] public Text tCh;
    [HideInInspector] public GameObject gCh;

    [HideInInspector] public Text tP1;
    [HideInInspector] public GameObject gP1;

    [HideInInspector] public Text tP2;
    [HideInInspector] public GameObject gP2;

    [HideInInspector] public Text tP3;
    [HideInInspector] public GameObject gP3;

    [HideInInspector] public Text tP4;
    [HideInInspector] public GameObject gP4;

    [HideInInspector] public Text tP5;
    [HideInInspector] public GameObject gP5;

    [HideInInspector] public Text tP6;
    [HideInInspector] public GameObject gP6;

    [HideInInspector] public Text tP7;
    [HideInInspector] public GameObject gP7;

    [HideInInspector] public Text tP8;
    [HideInInspector] public GameObject gP8;

    void Start()
    {
        //if (Fruits.sA == 0) {Destroy(gA);}
        //if (Fruits.sB == 0) {Destroy(gB);}
        //if (Fruits.sP == 0) {Destroy(gP);}
        //if (Fruits.sN == 0) {Destroy(gN);}
        //if (Fruits.sU == 0) {Destroy(gU);}
        //if (Fruits.sC == 0) {Destroy(gC);}
        //if (Fruits.sPz == 0) {Destroy(gPz);}
        //if (Fruits.sH == 0) {Destroy(gH);}
        //if (Fruits.sCh == 0) {Destroy(gCh);}

        if (Fruits.sA == 0) {gA.SetActive(false);}
        if (Fruits.sB == 0) {gB.SetActive(false);}
        if (Fruits.sP == 0) {gP.SetActive(false);}
        if (Fruits.sN == 0) {gN.SetActive(false);}
        if (Fruits.sU == 0) {gU.SetActive(false);}
        if (Fruits.sC == 0) {gC.SetActive(false);}
        if (Fruits.sPz == 0) {gPz.SetActive(false);}
        if (Fruits.sH == 0) {gH.SetActive(false);}
        if (Fruits.sCh == 0) {gCh.SetActive(false);}

        if (Potions.sp1 == 0) {gP1.SetActive(false);}
        if (Potions.sp2 == 0) {gP2.SetActive(false);}
        if (Potions.sp3 == 0) {gP3.SetActive(false);}
        if (Potions.sp4 == 0) {gP4.SetActive(false);}
        if (Potions.sp5 == 0) {gP5.SetActive(false);}
        if (Potions.sp6 == 0) {gP6.SetActive(false);}
        if (Potions.sp7 == 0) {gP7.SetActive(false);}
        if (Potions.sp8 == 0) {gP8.SetActive(false);}
    }

    void Update()
    {
        tA.text = "x" + Fruits.sA.ToString("0");
        tB.text = "x" + Fruits.sB.ToString("0");
        tP.text = "x" + Fruits.sP.ToString("0");
        tN.text = "x" + Fruits.sN.ToString("0");
        tU.text = "x" + Fruits.sU.ToString("0");
        tC.text = "x" + Fruits.sC.ToString("0");
        tPz.text = "x" + Fruits.sPz.ToString("0");
        tH.text = "x" + Fruits.sH.ToString("0");
        tCh.text = "x" + Fruits.sCh.ToString("0");

        tP1.text = "x" + Potions.sp1.ToString("0");
        tP2.text = "x" + Potions.sp2.ToString("0");
        tP3.text = "x" + Potions.sp3.ToString("0");
        tP4.text = "x" + Potions.sp4.ToString("0");
        tP5.text = "x" + Potions.sp5.ToString("0");
        tP6.text = "x" + Potions.sp6.ToString("0");
        tP7.text = "x" + Potions.sp7.ToString("0");
        tP8.text = "x" + Potions.sp8.ToString("0");
    }

    public void Close() 
    {
        Destroy(Fridge);
    }
}
