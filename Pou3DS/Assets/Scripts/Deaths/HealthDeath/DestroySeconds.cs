using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySeconds : MonoBehaviour
{
    public float maxTime;

    float timer;

    private void Update() 
    {
        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            Destroy();
        }
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
