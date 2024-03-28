using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatVenenoMatador : MonoBehaviour
{
    public GameObject canvas;
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.CompareTag("Pou"))
        {
            Status.resetData = true;

            Destroy(gameObject);

            FruitSelector.sActualFruit = 0;
        }
    }

    private void OnDestroy() 
    {
        Destroy(canvas);
    }
}
