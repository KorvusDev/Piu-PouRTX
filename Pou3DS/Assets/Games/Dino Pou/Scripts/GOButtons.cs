using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOButtons : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject Pause;

    public float maxTime;
    float timer;

    AudioSource death;

    public GameObject game;
    public GameObject pref;

    public static bool isReset;
    //Inicio
    void Start()
    {
        Death.isDeath = false;
        GameOverScreen.SetActive(false);
        death = GetComponent<AudioSource>();
    }

    //public void GameOverS()
    private void Update()
    {
        if (Death.isDeath == true)
        {
            GameOverScreen.SetActive(true); 
            Pause.SetActive(false);
            

            timer += Time.deltaTime;
        }

        else
        {
            Pause.SetActive(true);
        }

        if (timer >= maxTime)
        {
            death.Play();
            Time.timeScale = 0f;
        }

        PlayerAnims.isResetting1 = isReset;
        Obstacles.isResetting1 = isReset;
    }   

    //Botones
    public void Restart()
    {
        Time.timeScale = 1f;
        Death.isDeath = false;
        Obstacles.isResetting = true;
        StartCoroutine(resetGame(0));
        timer = 0;
    }
    
    public void MainMenu()
    {
        ActiveKitchen.sIsOn = true;
        Time.timeScale = 1f;
        Death.isDeath = false;
        StartCoroutine(resetGame(1));
        timer = 0;
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        Death.isDeath = false;
        timer = 0;
        Application.Quit();
    }

    IEnumerator resetGame(int i)
    {
        Money.sMoney += Score.score / 50; 

        Time.timeScale = 1f;
        isReset = true;
        yield return new WaitForSeconds(0.1f);
        isReset = false;
        Time.timeScale = 1f;
        Score.score = 0;
        GameOverScreen.SetActive(false);

        if (i == 1) {
        //game.SetActive(false);
        Destroy(game);}
        
        if (i == 0) {Instantiate(pref); Destroy(game);}
    }
}