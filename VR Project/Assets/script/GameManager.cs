using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public int Scene_nubmer;
    static public float height;
    static public bool isRetry;
    static public string position;
    private string[] pos_name = { "지상", "대류권", "성층권", "오존층" };

    public GameObject Player;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        Scene_nubmer = 1;
        height = 1f;
        isRetry = false;
        position = string.Empty;
    }

    private void Update()
    {
        height = Player.GetComponent<Transform>().position.y;
        position = pos_name[(int)(height) % 10000];
    }

    public float getHeight()
    {
        return height;
    }
    
    public string getPosition()
    {
        return position; 
    }
}
