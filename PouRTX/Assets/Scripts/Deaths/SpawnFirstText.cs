using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFirstText : MonoBehaviour
{
    public GameObject SpawnText;
    void Start()
    {
        Instantiate(SpawnText);
    }
}
