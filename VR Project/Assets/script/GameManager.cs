using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public int Scene_nubmer;
    static public float height;
    static public bool isRetry;
    static public string position;
    private string[] pos_name = { "Áö»ó", "¿ÀÁ¸Ãþ" };
    public bool isGrabSword;
    public bool isOzoneBroke;
    public bool ifFullGauge;

    public GameObject Player;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        Scene_nubmer = 1;
        height = 1f;
        isRetry = false;
        position = string.Empty;
        isGrabSword= false;
        isOzoneBroke= false;
        ifFullGauge= false;
    }

    private void Update()
    {
        height = Player.GetComponent<Transform>().position.y;
        height = ((int)(height) > 0 ? 23 : 0);
        position = pos_name[((int)(height) > 0 ? 1 : 0)];

    }

    public float getHeight()
    {
        return height;
    }
    
    public string getPosition()
    {
        return position; 
    }

    public void GrabSword()
    {
        isGrabSword = true;
    }

    public void DestroyAllOzone()
    {
        GameObject[] ozones = GameObject.FindGameObjectsWithTag("Ozone");
        for(int i = 0; i < ozones.Length; i++)
        {
            ozones[i].SetActive(false);
        }
    }
}
