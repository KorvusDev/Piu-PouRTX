using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlappyPou : MonoBehaviour
{
    [Header ("Settings")]
    public float jump;
    public Rigidbody2D rb2D;
    public GameObject fire;
    float timer;
    public float scale;
    public static float sScale;
    public Text tPoints;
    public Text tsPoints;

    [Header ("Game")]
    public bool isDeath;
    public static bool sIsDeath;
    
    public float point;
    public static float staticPoint;
    public float sPoint;

    public Vector2 startPos;

    private AudioSource jetpack;

    public static bool isResetting;
    float resetTime;
    public GameObject Terrain;

    void Start()
    {
        sPoint = PlayerPrefs.GetFloat("FlappyPouScore");
        Time.timeScale = 1f;
        rb2D = GetComponent<Rigidbody2D>();

        jetpack = GetComponent<AudioSource>();

        startPos = gameObject.transform.position;
    }

    void Update()
    {
        resetTime += Time.deltaTime;

        if (isResetting) {
            gameObject.transform.position = startPos; resetTime = 0;
            }

        //if (resetTime >= 0 && resetTime <= 0.3) {Terrain.SetActive(true);}

        else {Terrain.SetActive(false);}

        if (!InGameMenus.sIsInPause)
        {
            point = staticPoint;
            tPoints.text = point.ToString("0");
            if (scale <= Time.timeScale) {scale = Time.timeScale;}
            sScale = scale;
            isDeath = sIsDeath; 
            if (!isDeath)
            {
                timer += Time.deltaTime;

                if (Input.GetKeyDown("mouse 0") || Input.GetKeyDown("w") || Input.GetKeyDown("up")) 
                {
                    rb2D.velocity = new Vector2(0, jump);
                    fire.SetActive(true);
                    timer = 0;
                    jetpack.Play();
                }

                if (timer >= jump / 30)
                {
                    fire.SetActive(false);
                }
            }

            else
            {
                fire.SetActive(false);
            } 

            if (point >= sPoint)
            {
                sPoint = point;
                PlayerPrefs.SetFloat("FlappyPouScore", point);
            }

            tsPoints.text = sPoint.ToString("0");
        }

        if (sIsDeath || InGameMenus1.sIsInPause)
        {
            jetpack.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.CompareTag("Obstacle"))
        {
            sIsDeath = true;
        }

        if (col.CompareTag("Terrain"))
        {
            sIsDeath = true;
            StartCoroutine(SetAsDeath());
        }

        if (col.CompareTag("Point"))
        {
            staticPoint++;
            //Time.timeScale += moreVel;
            Status.sFunLevel = Status.sFunLevel + 150;
            Status.sHealthLevel = Status.sHealthLevel + 50;
            Status.sFullnessLevel = Status.sFullnessLevel - 50;
            Status.sEnergyLevel = Status.sEnergyLevel - 150;
        }
    }

    IEnumerator SetAsDeath()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
    }
    //float moreVel = 0.1f;
}
