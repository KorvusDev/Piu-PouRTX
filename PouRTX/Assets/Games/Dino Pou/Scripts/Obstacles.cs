using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
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

    [Header ("Movement")]
    public float start;

    [Header ("Restart")]
    public static bool isResetting;
    public static bool isResetting1;


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
                Obstacle[last].transform.position = new Vector2(start, 2);
                yield return new WaitForSeconds(randomTime);        
            }
            
            yield return new WaitForSeconds(0.1f);
        }

        StartCoroutine(SpawnObstacles());
    }

    private void Update() 
    {
        if (isResetting || isResetting1)
        {
            for(int i = 0; i < Obstacle.Length; i++) 
            {
                Obstacle[i].transform.position = new Vector2(-100, 2);
            }
        }
    }
}
