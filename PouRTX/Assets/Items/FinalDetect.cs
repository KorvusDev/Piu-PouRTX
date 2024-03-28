using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDetect : MonoBehaviour
{
    public static float sIsInFinal;

    public float isInFinal;

    void Start() 
    {
        sIsInFinal = 0;
    }

    void Update()
    {
        isInFinal = sIsInFinal;
        if (isInFinal != 0) {Destroy(gameObject);}
    }
}
