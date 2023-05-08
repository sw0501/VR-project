using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class GameManagerTest_Prototype : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public GameObject Ozone;

    public bool isEnd;

    private void Awake()
    {
        score = 0;
        isEnd = false;
    }

    public void getScore()
    {
        score++;
    }

    public void SetOzone()
    {
        Ozone.SetActive(true);
    }

    public void EndContribution()
    {
        isEnd= true;
    }
}
