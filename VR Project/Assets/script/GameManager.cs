using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Scene_nubmer;
    public float height;
    public bool isRetry;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        Scene_nubmer = 1;
        height = 0f;
        isRetry = false;
    }


}
