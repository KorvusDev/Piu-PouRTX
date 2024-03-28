using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenus1 : MonoBehaviour
{
    public GameObject Pause;
    public GameObject DeathA;
    public GameObject PauseBtn;

    public GameObject aGame;
    public GameObject pref;

    public bool isInPause;
    public static bool sIsInPause;

    public string Game;

    public static bool isReset;

    public float _TimeScale;

    void Start()
    {
        Pause.SetActive(false);
        PauseBtn.SetActive(false);

        isReset = false;
    }

    void Update()
    {
        sIsInPause = isInPause;

        if (Game == "FlappyPou")
        {
            DeathA.SetActive(FlappyPou.sIsDeath);

            if (FlappyPou.sIsDeath)
            {
                PauseBtn.SetActive(false);
                Pause.SetActive(false);
            }

            else
            {
                PauseBtn.SetActive(!isInPause);
                Pause.SetActive(isInPause);
            }

            FlappyPool.isResetting = isReset;
            FlappyPou.isResetting = isReset;
        }

        if (Game == "PouJump")
        {
            DeathA.SetActive(Death.isDeath);

            if (!isInPause)
            {
                _TimeScale = Time.timeScale;
            }

            if (Death.isDeath)
            {
                PauseBtn.SetActive(false);
                Pause.SetActive(false);
            }

            else
            {
                PauseBtn.SetActive(!isInPause);
                Pause.SetActive(isInPause);
            }

            PlayerAnims.isResetting = isReset;
            Obstacles.isResetting = isReset;
        }

        if (isInPause) {Time.timeScale = 0.001f;}
    }

    public void QuitGame() {Time.timeScale = 1f; StartCoroutine(addMoney(0));}
    public void PauseGame() 
    {
        if (!isInPause) 
        {
            isInPause = true; Time.timeScale = 0.001f; 
        }
        else 
        {
            if (Game == "FlappyPou") 
            {
                Time.timeScale = 1f; isInPause = false; 
                if (Game == "DinoPou")
                {
                    isInPause = false;
                }
            }

            if (Game == "PouJump") 
            {
                Time.timeScale = _TimeScale; isInPause = false; 
                if (Game == "FlappyPou")
                {
                    isInPause = false;
                }
            }
        }
    }
    public void MainMenu() {Time.timeScale = 1f; StartCoroutine(addMoney(1));}
    public void RestartGame() {Time.timeScale = 1f; StartCoroutine(addMoney(2));}

    IEnumerator addMoney(int Func)
    {
        Time.timeScale = 1f;
        if (Game == "FlappyPou") 
        {
            if (FlappyPou.sIsDeath) 
            {
                Money.sMoney += FlappyPou.staticPoint / 2; 
                FlappyPou.sIsDeath = false; 
            }

            FlappyPou.staticPoint = 0; 
            isInPause = false;
        }

        Time.timeScale = 1f;
        if (Game == "PouJump") 
        {
            if (Death.isDeath) 
            {
                Money.sMoney += Score.score / 50; 
                Death.isDeath = false; 
            }

            Score.score = 0;
            isInPause = false;
        }

        yield return new WaitForSeconds(0.1f);
        if (Func == 0) {Time.timeScale = 1f; Application.Quit(); StartCoroutine(addMoney(0));}
        if (Func == 1) {Time.timeScale = 1f; ActiveKitchen.sIsOn = true; StartCoroutine(addMoney(1)); StartCoroutine(resetGame(1));}
        if (Func == 2) {Time.timeScale = 1f; StartCoroutine(resetGame(0)); StartCoroutine(addMoney(2));}
    }

    IEnumerator resetGame(int i)
    {
        Time.timeScale = 1f;
        isReset = true;
        yield return new WaitForSeconds(0.1f);

        sIsInPause = false;
        FlappyPou.sIsDeath = false;

        if (i == 0) {Instantiate(pref);}
        
        isReset = false;
        Time.timeScale = 1f;

        if (i == 1 || i == 0) {//aGame.SetActive(false);
        Destroy(aGame);
            }
    }
}
