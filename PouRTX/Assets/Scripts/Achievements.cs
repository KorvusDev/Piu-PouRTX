using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    public string[] logros;
    public bool[] menuLogros;
    public int[] logrosConseguidos;

    void Start()
    {
        logrosConseguidos[0] = PlayerPrefs.GetInt("Diversión");
        logrosConseguidos[1] = PlayerPrefs.GetInt("Salud");
        logrosConseguidos[2] = PlayerPrefs.GetInt("Saciedad");
        logrosConseguidos[3] = PlayerPrefs.GetInt("Borrar");
    }

    void Update()
    {
        
    }
}
