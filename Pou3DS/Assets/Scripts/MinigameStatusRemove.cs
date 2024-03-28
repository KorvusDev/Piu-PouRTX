using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameStatusRemove : MonoBehaviour
{
    void Start()
    {
        Status.sEnergyLevel = Status.sEnergyLevel - 100;
        Status.sFullnessLevel = Status.sFullnessLevel - 50;
        Status.sHealthLevel = Status.sHealthLevel + 100;
        Status.sFunLevel = Status.sFunLevel + 200;
    }
}
