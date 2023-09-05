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
    private XRController left_Controller;
    private XRController right_Controller;
    public GameObject Player;

    IEnumerator Vibrate()
    {
        GameObject Camera = GameObject.FindGameObjectWithTag("Player");
        Quaternion quaterninon = Quaternion.identity;

        int cnt = 0;

        quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z + 10);

        //20번 진동 반복
        while (cnt<20)
        {
            Debug.Log(12312);
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation =  quaterninon;
            yield return new WaitForSeconds(0.05f);
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation = quaterninon;
            yield return new WaitForSeconds(0.05f);
            cnt++;
        }

        quaterninon.eulerAngles = new Vector3(0, 0, 0);
    }

    //Scene 이동 시 오브젝트 파괴 X
    private void Awake()
    {
        DontDestroyOnLoad(this);

        left_Controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        right_Controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];
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
        left_Controller.SendHapticImpulse(0.7f, 2f);
        right_Controller.SendHapticImpulse(0.7f, 2f);
    }
    
    //플레이어 진동
    public void VibratePlayer()
    {
        //StartCoroutine(Vibrate());
    }

    public void FallPlayer()
    {
        Player.AddComponent<Rigidbody>().useGravity = true;
    }
}
