using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public float a;
    public static float sA;

    public float b;
    public static float sB;

    public float p;
    public static float sP;

    public float n;
    public static float sN;

    public float u;
    public static float sU;

    public float c;
    public static float sC;

    public float pz;
    public static float sPz;

    public float h;
    public static float sH;

    public float ch;
    public static float sCh;

    void Start()
    {
        sA = PlayerPrefs.GetFloat("A");
        sB = PlayerPrefs.GetFloat("B");
        sP = PlayerPrefs.GetFloat("P");
        sN = PlayerPrefs.GetFloat("N");
        sU = PlayerPrefs.GetFloat("U");
        sC = PlayerPrefs.GetFloat("C");
        sPz = PlayerPrefs.GetFloat("Pz");
        sH = PlayerPrefs.GetFloat("H");
        sCh = PlayerPrefs.GetFloat("Ch");
    }

    void FixedUpdate()
    {
        if (sA != a)
        {
            a = sA;
            PlayerPrefs.SetFloat("A", sA);
        }

        if (sB != b)
        {
            b = sB;
            PlayerPrefs.SetFloat("B", sB);
        }

        if (sP != p)
        {
            p = sP;
            PlayerPrefs.SetFloat("P", sP);
        }

        if (sN != n)
        {
            n = sN;
            PlayerPrefs.SetFloat("N", sN);
        }

        if (sU != u)
        {
            u = sU;
            PlayerPrefs.SetFloat("U", sU);
        }

        if (sC != c)
        {
            c = sC;
            PlayerPrefs.SetFloat("C", sC);
        }

        if (sPz != pz)
        {
            pz = sPz;
            PlayerPrefs.SetFloat("Pz", sPz);
        }

        if (sH != h)
        {
            h = sH;
            PlayerPrefs.SetFloat("H", sH);
        }

        if (sCh != ch)
        {
            ch = sCh;
            PlayerPrefs.SetFloat("Ch", sCh);
        }

        if (sA <= -0.1) {sA = 0;}
        if (sB <= -0.1) {sB = 0;}
        if (sP <= -0.1) {sP = 0;}
        if (sN <= -0.1) {sN = 0;}
        if (sU <= -0.1) {sU = 0;}
        if (sC <= -0.1) {sC = 0;}
        if (sPz <= -0.1) {sPz = 0;}
        if (sH <= -0.1) {sH = 0;}
        if (sCh <= -0.1) {sCh = 0;}
    }
}
