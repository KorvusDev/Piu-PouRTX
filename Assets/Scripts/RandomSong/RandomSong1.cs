using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSong1 : MonoBehaviour
{
    public float duration;
    public float timer;
    float randomSong;

    public GameObject Q;
    public GameObject W;
    public GameObject E;
    public GameObject R;
    public GameObject T;
    public GameObject Y;
    public GameObject U;
    public GameObject I;

    void Update()
    {
        //timer += Time.deltaTime;
        if (duration <= timer) 
        {
            timer = 0;
            Destroy();
        }
    }

    void Destroy()
    {
        randomSong = Random.Range(1, 8);
        if (randomSong == 1) {Instantiate(Q);}
        if (randomSong == 2) {Instantiate(W);}
        if (randomSong == 3) {Instantiate(E);}
        if (randomSong == 4) {Instantiate(R);}
        if (randomSong == 5) {Instantiate(T);}
        if (randomSong == 6) {Instantiate(Y);}
        if (randomSong == 7) {Instantiate(U);}
        if (randomSong == 8) {Instantiate(I);}
        Destroy(gameObject);
    }
}
