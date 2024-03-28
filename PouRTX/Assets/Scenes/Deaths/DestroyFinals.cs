using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinals : MonoBehaviour
{
    public GameObject Final;

    private void Update() 
    {
        Final.SetActive(false);
    }
}
