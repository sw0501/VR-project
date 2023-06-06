using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public UnityEvent Test;
    private XRController xr;

    IEnumerator Vibrate()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Quaternion quaterninon = Quaternion.identity;

        int cnt = 0;

        quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z + 10);

        //20번 진동 반복
        while (cnt<20)
        {
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation =  quaterninon;
            yield return new WaitForSeconds(0.01f);
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation = quaterninon;
            yield return new WaitForSeconds(0.01f);
            cnt++;
        }
        
        
    }

    //Scene 이동 시 오브젝트 파괴 X
    private void Awake()
    {
        xr = (XRController)GameObject.FindObjectOfType(typeof(XRController));
        DontDestroyOnLoad(this);
    }

    //Scene 시작 시 Player Controller 저장
    void Start()
    {

    }

    private void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space)) {
            Test.Invoke();
        }
        */
    }

    //컨트롤러에 진동 
    public void ActivateHaptic()
    {
        //Debug.Log("Haptic");
        xr.SendHapticImpulse(0.7f, 2f);
    }
    
    //플레이어 진동
    public void VibratePlayer()
    {
        
    }

    //컨트롤러에 Red 이펙트
    public void EffectController(string color)
    {

        Debug.Log(color);
        switch (color)
        {
            case "red":
                break;
            case "yellow":
                break;
            case "green":
                break;

        }
    }
}
