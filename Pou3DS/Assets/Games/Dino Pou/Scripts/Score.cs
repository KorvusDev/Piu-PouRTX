using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text HIScoreText;
    public static int score;
    Text scoreText;

    float timer;
    float maxTime;

    AudioSource scoreSound;

    void Start()
    {
        HIScoreText.text = PlayerPrefs.GetInt("highscore", 0).ToString("0");
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
        scoreSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        timer += Time.deltaTime / 2;
        if (timer >= maxTime)
        {
            if (!Death.isDeath)
            {
                score++;
                scoreText.text = score.ToString("0");
                timer = 0;

                if(score % 100 == 0)
                {
                    scoreSound.Play();
                }

                if (score % 1 == 0)
                {
                    Time.timeScale += 0.001f;
                }
            }
        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                HIScoreText.text = PlayerPrefs.GetInt("highscore", 0).ToString("0");
            }
        }
    }
}
