using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStats : MonoBehaviour
{
    public string Pref;
    void Start()
    {
        PlayerPrefs.SetFloat("Energy", 172800);
        PlayerPrefs.SetFloat("Fullness", 86400);
        PlayerPrefs.SetFloat("Health", 172800);
        PlayerPrefs.SetFloat("Fun", 86400);

        PlayerPrefs.SetFloat("p1", 0);
        PlayerPrefs.SetFloat("p2", 0);
        PlayerPrefs.SetFloat("p3", 0);
        PlayerPrefs.SetFloat("p4", 0);
        PlayerPrefs.SetFloat("p5", 0);
        PlayerPrefs.SetFloat("p6", 0);
        PlayerPrefs.SetFloat("p7", 0);
        PlayerPrefs.SetFloat("p8", 0);

        PlayerPrefs.SetFloat("A", 0);
        PlayerPrefs.SetFloat("B", 0);
        PlayerPrefs.SetFloat("P", 0);
        PlayerPrefs.SetFloat("N", 0);
        PlayerPrefs.SetFloat("U", 0);
        PlayerPrefs.SetFloat("C", 0);
        PlayerPrefs.SetFloat("Pz", 0);
        PlayerPrefs.SetFloat("H", 0);
        PlayerPrefs.SetFloat("Ch", 0);

        PlayerPrefs.SetFloat("money", 0);

        PlayerPrefs.SetInt(Pref, 1);
    }
}
