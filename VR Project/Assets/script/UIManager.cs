using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int Scene_number;
    public TMP_Text height;
    public TMP_Text position;

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadScene()
    {
        if (Scene_number < 4)
        {
            SceneManager.LoadScene(Scene_number + 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    //Direction Light ºû Á¾·ù º¯°æ
    public void LightEffect()
    {

    }

    //ºûÀÌ Á¡Á¡ ²¨Áö´Â È¿°ú
    public void LightFadeAway()
    {

    }

    public void SetVisible()
    {

    }

    public void SetVisibleForest()
    {

    }

    public void SetVisiblePolar()
    {
        
    }

    public void SetVisibleApart()
    {

    }

    private void Update()
    {
        height.text = GameManager.height.ToString();
        position.text = GameManager.position.ToString();
    }
}
