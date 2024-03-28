using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{
    public float p1;
    public static float sp1;

    public float p2;
    public static float sp2;

    public float p3;
    public static float sp3;

    public float p4;
    public static float sp4;

    public float p5;
    public static float sp5;

    public float p6;
    public static float sp6;

    public float p7;
    public static float sp7;

    public float p8;
    public static float sp8;

    void Start()
    {
        sp1 = PlayerPrefs.GetFloat("p1");
        sp2 = PlayerPrefs.GetFloat("p2");
        sp3 = PlayerPrefs.GetFloat("p3");
        sp4 = PlayerPrefs.GetFloat("p4");
        sp5 = PlayerPrefs.GetFloat("p5");
        sp6 = PlayerPrefs.GetFloat("p6");
        sp7 = PlayerPrefs.GetFloat("p7");
        sp8 = PlayerPrefs.GetFloat("p8");
    }

    void Update()
    {
        if (p1 != sp1)
        {
            p1 = sp1;
            PlayerPrefs.SetFloat("p1", sp1);
        }

        if (p2 != sp2)
        {
            p2 = sp2;
            PlayerPrefs.SetFloat("p2", sp2);
        }

        if (p3 != sp3)
        {
            p3 = sp3;
            PlayerPrefs.SetFloat("p3", sp3);
        }

        if (p4 != sp4)
        {
            p4 = sp4;
            PlayerPrefs.SetFloat("p4", sp4);
        }

        if (p5 != sp5)
        {
            p5 = sp5;
            PlayerPrefs.SetFloat("p5", sp5);
        }

        if (p6 != sp6)
        {
            p6 = sp6;
            PlayerPrefs.SetFloat("p6", sp6);
        }

        if (p7 != sp7)
        {
            p7 = sp7;
            PlayerPrefs.SetFloat("p7", sp7);
        }

        if (p8 != sp8)
        {
            p8 = sp8;
            PlayerPrefs.SetFloat("p8", sp8);
        }
    }
}
