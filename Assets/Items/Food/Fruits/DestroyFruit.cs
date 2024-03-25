using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFruit : MonoBehaviour
{
    public float fruitNumber;

    void Update()
    {
        if (FruitSelector.sActualFruit != fruitNumber) {Destroy(gameObject);}
    }
}
