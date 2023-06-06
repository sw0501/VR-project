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
    public TMP_Text swordSubtitle;
    public Slider gauge;
    public Image image;

    public GameObject positionPanel;

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while(fadeCount < 1.0f){
            fadeCount += 0.005f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0,0,0,fadeCount);
        }
        
    }


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

    public void ChangeSubtitle()
    {
        switch(gauge.value)
        {
            case 1:
                subtitle.text = "무분별한 에어컨 사용!";
                break;
            case 2:
                subtitle.text = "제초제 사용!";
                break;
            case 3:
                subtitle.text = "차량 냉각제 사용!";
                break;
            case 4:
                subtitle.text = "무분별한 화장품 및 헤어스프레이 사용!";
                break;
            case 5:
                subtitle.text = "건물 내부 및 외부에 구식 절연재 사용!";
                break;
            case 6:
                subtitle.text = "무분별한 고체 폐기물 소각!";
                break;
            case 7:
                subtitle.text = "무분별한 소화기 사용!";
                break;
            case 8:
                subtitle.text = "무분별한 플라스틱 제조 및 가공 증가";
                break;
            case 9:
                subtitle.text = "항공 운송 및 비행기 운항의 증가";
                break;
            case 10:
                subtitle.text = "무분별한 소형 가전 제품 사용!";
                break;
            case 11:
                subtitle.text = "산업 공정에서의 CFC사용 증가!";
                break;
            case 12:
                subtitle.text = "무분별한 기름 기반 제품(윤활유, 스프레이) 사용!";
                break;
            case 13:
                subtitle.text = "무분별한 부식 방지제 사용!";
                break;
            case 14:
                subtitle.text = "폴리우레탄으로 만들어진 침대 메트리스 사용!";
                break;
            case 15:
                subtitle.text = "무분별한 청소용 액체 사용!";
                break;
            case 16:
                subtitle.text = "LED가 아닌 형광등 및 조명 사용!";
                break;
            case 17:
                subtitle.text = "인쇄 공정에서의 용매 사용 증가!";
                break;
            case 18:
                subtitle.text = "무분별한 산업용 보일러와 난방 시스템 사용!";
                break;
            case 19:
                subtitle.text = "콘크리트 생산 증가!";
                break;
            case 20:
                subtitle.text = "폐기물 처리장에서 발생하는 가스 증가!";
                break;
            case 21:
                subtitle.text = "수영장에서 클로로포름 사용!";
                break;
            case 22:
                subtitle.text = "소독을 위한 무분별한 화학물질 사용!";
                break;
            case 23:
                subtitle.text = "건물 내부에서의 냉난방 시스템 관리 부족!";
                break;
            case 24:
                subtitle.text = "무분별한 광학 기기 제조 및 사용!";
                break;
            case 25:
                subtitle.text = "농업 부문에서 무분별한 살충제와 비료 사용!";
                break;
            case 26:
                subtitle.text = "무분별한 금속 가공 및 제조 증가!";
                break;
            case 27:
                subtitle.text = "흡수식 냉각기 사용 증가!";
                break;
            case 28:
                subtitle.text = "자동차 관리 부족으로 인한 냉매 유출!";
                break;
            case 29:
                subtitle.text = "잘못된 식품 가공과 보존 증가!";
                break;
            case 30:
                subtitle.text = "가즈로 작동괴는 장비 및 기계 사용 증가!";
                break;
        }
    }

    public void ChangeSwordSubtitle(string text)
    {
        swordSubtitle.text = text;
    }

    public void IncreaseGaugeValue()
    {
        gauge.value += 1;
        this.ChangeSubtitle();
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

    public void FadeOut(){
        StartCoroutine(FadeCoroutine());
    }
}
