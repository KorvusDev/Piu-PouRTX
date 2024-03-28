using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    [SerializeField] private GameObject PauseButton;
    [SerializeField] private GameObject PausaMenu;
    private bool PausedGame = false;
    public static bool isPause;

    public float tScale;
    public float currentTimeScale;

    public GameObject game;
    public GameObject pref;

    public static bool isReset;

    void Start()
    {
        PausaMenu.SetActive(false);   
        PauseButton.SetActive(true);
    }
  
    private void Update()
    {
        if (!isPause) {tScale = Time.timeScale;}
        isPause = PausedGame;
        currentTimeScale = Time.timeScale;
        if(Input.GetKeyDown(KeyCode.Escape) && Death.isDeath == false)
        {
            if(PausedGame)
            {
                Time.timeScale = tScale;
                PlayGame();
            }
            else
            {
                tScale = Time.timeScale;
                PauseMenu();
            }
        }
        if (Death.isDeath == true)
        {  
            PauseButton.SetActive(false); 
        }

        //if (Death.isDeath == false)
        //{  
            //PauseButton.SetActive(true); 
        //}

        PlayerAnims.isResetting = isReset;
        Obstacles.isResetting = isReset;
    }

    public void PauseMenu()
    {
        tScale = Time.timeScale;
        PausedGame = true;
        Time.timeScale = 0f;    
        PauseButton.SetActive(false);
        PausaMenu.SetActive(true);
    }

    public void PlayGame()
    {
        Time.timeScale = tScale;
        PausedGame = false;
        Time.timeScale = 1f;
        PauseButton.SetActive(true);
        PausaMenu.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Obstacles.isResetting = true;
        StartCoroutine(resetGame(0));
        PausaMenu.SetActive(false);
        PausedGame = false;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        Obstacles.isResetting = true;
        PausaMenu.SetActive(false);
        PausedGame = false;

        ActiveKitchen.sIsOn = true;
        Death.isDeath = false;
        StartCoroutine(resetGame(1));
        //if (i == 1) {Destroy(game);}
    }
 
    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator resetGame(int i)
    {
        Time.timeScale = 1f;
        isReset = true;
        yield return new WaitForSeconds(0.1f);
        Death.isDeath = false;
        isReset = false;
        Time.timeScale = 1f;
        Score.score = 0;
        PausaMenu.SetActive(false);
        PausedGame = false;
        if (i == 0) {//game.SetActive(false);
        Instantiate(pref);
        Destroy(game);}
        if (i == 1) {Destroy(game);}
    }
}
