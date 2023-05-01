using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int Scene_number;

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadScene()
    {
        if(Scene_number < 4)
        {
            SceneManager.LoadScene(Scene_number + 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}
