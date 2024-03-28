using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenus : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Death;
    public GameObject PauseBtn;

    public bool isInPause;
    public static bool sIsInPause;

    public string Game;

    void Start()
    {
        Pause.SetActive(false);
        PauseBtn.SetActive(false);
    }

    void Update()
    {
        sIsInPause = isInPause;

        if (Game == "FlappyPou")
        {
            Death.SetActive(FlappyPou.sIsDeath);

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
        }

        //if (isInPause) {Time.timeScale = 0.001f;}
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
                Time.timeScale = FlappyPou.sScale; isInPause = false; 
                if (Game == "DinoPou")
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
        if (Game == "FlappyPou") {if (FlappyPou.sIsDeath) {Money.sMoney += FlappyPou.staticPoint / 2;}}
        yield return new WaitForSeconds(0.1f);
        if (Func == 0) {Time.timeScale = 1f; Application.Quit();}
        if (Func == 1) {Time.timeScale = 1f; SceneManager.LoadScene("Kitchen");}
        if (Func == 2) {Time.timeScale = 1f; SceneManager.LoadScene(SceneManager.GetActiveScene().name);}
    }

    
}
