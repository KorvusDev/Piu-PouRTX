using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nevera : MonoBehaviour
{
    public GameObject Fridge;

    public Text tA;
    public GameObject gA;

    public Text tB;
    public GameObject gB;

    public Text tP;
    public GameObject gP;

    public Text tN;
    public GameObject gN;

    public Text tU;
    public GameObject gU;

    public Text tC;
    public GameObject gC;

    public Text tPz;
    public GameObject gPz;

    public Text tH;
    public GameObject gH;

    public Text tCh;
    public GameObject gCh;

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
    }

    public void Close() 
    {
        Destroy(Fridge);
    }
}
