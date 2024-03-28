using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStatus1 : MonoBehaviour
{
    public GameObject panel;
    public bool isActived;

    float touchs;

    float returnToActive = 1;

    void Start()
    {
        panel.SetActive(false);
        isActived = false;
    }

    void Update()
    {
        panel.SetActive(isActived);

        if (isActived) {if (touchs == 1) {isActived = !isActived; touchs = 0;}}
        else {if (touchs == 3) {isActived = !isActived;touchs = 0;}}
    }

    public void ChangeBtn()
    {
        touchs++;
    }
}
