using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStatusMenu : MonoBehaviour
{
    public GameObject[] Button;
    public float Pass;

    public float isActived;

    public void BtnClick(int Btn)
    {
        Pass = Btn;
        Button[Btn].SetActive(true);
        Button[Btn - 1].SetActive(false);
    }

    void Start()
    {
        isActived = PlayerPrefs.GetFloat("StatusPanel");
    }

    void Update()
    {
        if (isActived == 1)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(false);
            Button[2].SetActive(false);
            Button[3].SetActive(true);
        }
    }
}
