using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStatus : MonoBehaviour
{
    public GameObject panel;
    public bool isActived;

    float returnToActive = 1;

    void Start()
    {
        panel.SetActive(false);
        isActived = false;
    }

    void Update()
    {
        panel.SetActive(isActived);
    }

    public void ChangeBtn()
    {
        isActived = !isActived;
        StartCoroutine(SetTrue(isActived));
    }

    IEnumerator SetTrue(bool active)
    {
        yield return new WaitForSeconds(0.1f);
        if (active) {PlayerPrefs.SetFloat("StatusPanel", returnToActive);}
    }
}
