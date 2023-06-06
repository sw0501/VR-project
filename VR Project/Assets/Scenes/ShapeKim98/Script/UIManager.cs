using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public TMP_Text subtitle;
    public TMP_Text heightText;
    public TMP_Text locationText;
    public Slider gauge;

    public GameObject positionPanel;

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        this.HideUIObject();
    }

    private void Update()
    {
        heightText.text =  "고도 : " + gameManager.getHeight() + "m";
        locationText.text = "위치 : " + gameManager.getPosition();
    }

    public void ChangeSubtitle(string text)
    {
        subtitle.text = text;
    }

    public void IncreaseGaugeValue()
    {
        gauge.value += 1;
    }

    public bool IsFullGauge()
    {
        return gauge.value == gauge.maxValue ? true : false;
    }

    public void HideGauge()
    {
        gauge.gameObject.SetActive(false);
    }

    public void ShowGauge()
    {
        gauge.gameObject.SetActive(true);
    }

    public void HideSubtitle()
    {
        subtitle.enabled = false;
    }

    public void ShowSubtitle() { 
        subtitle.enabled = true;
    }

    public void SwitchSceneByNumber(int number) {
        switch(number) {
            case 1:
            this.HideUIObject();
            break;
            case 2:
            this.HideUIObject();
            break;
            case 3:
            this.HideUIObject();
            break;
            case 4:
            this.HideUIObject();
            break;
            case 5:
            this.HideUIObject();
            break;
            case 6:
            positionPanel.gameObject.SetActive(true);
            break;
            case 7:
            positionPanel.gameObject.SetActive(true);
            break;
            case 8:
            positionPanel.gameObject.SetActive(true);
            break;
            case 9:
            positionPanel.gameObject.SetActive(true);
            break;
            case 10:
            positionPanel.gameObject.SetActive(true);
            gauge.gameObject.SetActive(false);
            break;
            case 11:
            positionPanel.gameObject.SetActive(true);
            gauge.gameObject.SetActive(false);
            break;
            case 12:
            positionPanel.gameObject.SetActive(true);
            gauge.gameObject.SetActive(false);
            break;
            case 13:
            positionPanel.gameObject.SetActive(true);
            gauge.gameObject.SetActive(false);
            break;
            case 14:
            this.HideUIObject();
            break;
            default:
            Debug.Log("Invalid Scene Number");
            break;
        }
    }

    public void HideUIObject() {
        subtitle.enabled = false;
        positionPanel.gameObject.SetActive(false);
        gauge.gameObject.SetActive(false);
    }
}
