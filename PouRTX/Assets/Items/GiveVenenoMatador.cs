using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveVenenoMatador : MonoBehaviour
{
    public GameObject VenenoMatador;

    public void BtnVenenoMatador(int venenoID)
    {
        StartCoroutine(SpawnVenenoMatador(venenoID));
    }

    IEnumerator SpawnVenenoMatador(int venenoID)
    {
        FruitSelector.sActualFruit = 0;
        yield return new WaitForSeconds(0.1f);
        FruitSelector.sActualFruit = venenoID;
        yield return new WaitForSeconds(0.01f);
        Instantiate(VenenoMatador);
    }
}
