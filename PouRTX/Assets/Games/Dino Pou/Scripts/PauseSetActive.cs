using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSetActive : MonoBehaviour
{
    public GameObject Pause;
    void Start()
    {
        StartCoroutine(Destroy());
    }

    void Update()
    {
        Pause.SetActive(true);
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
