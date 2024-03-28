using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSong : MonoBehaviour
{
    public GameObject[] Songs;
    public bool bSong;
    public string Game;

    bool isInPause;
    bool IsDeath;

    void Start()
    {
        StartCoroutine(Song());
    }

    void Update()
    {
        if (Game == "Flappy Pou")
        {
            if (FlappyPou.sIsDeath || InGameMenus1.sIsInPause)
            {
                Songs[0].SetActive(false);
                Songs[1].SetActive(false);
            }

            if (IsDeath != FlappyPou.sIsDeath) {IsDeath = FlappyPou.sIsDeath; StartCoroutine(Song());}
            if (isInPause != InGameMenus1.sIsInPause) {isInPause = InGameMenus1.sIsInPause; StartCoroutine(Song());}
        }

        if (Game == "Pou Jump")
        {
            if (Death.isDeath || Pause.isPause)
            {
                Songs[0].SetActive(false);
                Songs[1].SetActive(false);
            }

            if (IsDeath != Death.isDeath) {IsDeath = Death.isDeath; StartCoroutine(Song());}
            if (isInPause != Pause.isPause) {isInPause = Pause.isPause; StartCoroutine(Song());}
        }
    }

    IEnumerator Song() 
    {
        if (Game == "Flappy Pou")
        {
            if (!FlappyPou.sIsDeath && !InGameMenus1.sIsInPause)
            {
                yield return new WaitForSeconds(0.1f);
                if (Status.sFunLevel <= 0 || Status.sHealthLevel <= 0 || Status.sEnergyLevel <= 0 || Status.sFullnessLevel <= 0) {bSong = true;}
                else {bSong = false;}
                if (bSong)  {Songs[0].SetActive(false); Songs[1].SetActive(true);}
                else {Songs[1].SetActive(false); Songs[0].SetActive(true);}
                yield return new WaitForSeconds(5.1f);
                StartCoroutine(Song());
            }
        }

        if (Game == "Pou Jump")
        {
            if (!Death.isDeath && !Pause.isPause)
            {
                yield return new WaitForSeconds(0.1f);
                if (Status.sFunLevel <= 0 || Status.sHealthLevel <= 0 || Status.sEnergyLevel <= 0 || Status.sFullnessLevel <= 0) {bSong = true;}
                else {bSong = false;}
                if (bSong)  {Songs[0].SetActive(false); Songs[1].SetActive(true);}
                else {Songs[1].SetActive(false); Songs[0].SetActive(true);}
                yield return new WaitForSeconds(5.1f);
                StartCoroutine(Song());
            }
        }
    }
}
