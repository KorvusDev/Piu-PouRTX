using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyPool : MonoBehaviour
{
    [Header ("Obstacles")]
    public int obstacleNumber;
    public GameObject[] Obstacle;

    [Header ("Random Generator")]
    public int last;
    public float randomTime;

    [Header ("Values")]
    public float minTime;
    public float maxTime;
    public float minHeight;
    public float maxHeight;

    [Header ("Movement")]
    public float start;

    [Header ("Restart")]
    public static bool isResetting;


    void Start() 
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        if (!InGameMenus.sIsInPause)
        {
            last = Random.Range(0, obstacleNumber - 1);
            randomTime = Random.Range(minTime, maxTime);
            if (Obstacle[last].transform.position.x <= -50) 
            {
                Obstacle[last].transform.position = new Vector2(start, Random.Range(minHeight, maxHeight));
                yield return new WaitForSeconds(randomTime);        
            }
            
            yield return new WaitForSeconds(0.1f);
        }

        StartCoroutine(SpawnObstacles());
    }

    private void Update() 
    {
        if (isResetting)
        {
            for(int i = 0; i < Obstacle.Length; i++) 
            {
                Obstacle[i].transform.position = new Vector2(-100, Random.Range(minHeight, maxHeight));
            }
        }
    }
}
