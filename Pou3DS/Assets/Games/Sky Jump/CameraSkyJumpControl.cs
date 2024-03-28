using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSkyJumpControl : MonoBehaviour
{
    public GameObject pou;

    void Update()
    {
        if (pou.transform.position.y >= gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector2(0, pou.transform.position.y);
        }
    }
}
