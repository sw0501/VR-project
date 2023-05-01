using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class PlayerManager : MonoBehaviour
{

    //Scene 이동 시 오브젝트 파괴 X
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private XRController xr;

    //Scene 시작 시 Player Controller 저장
    void Start()
    {
        xr = (XRController)GameObject.FindObjectOfType(typeof(XRController));
    }

    //컨트롤러에 진동 
    void ActivateHaptic()
    {
        xr.SendHapticImpulse(0.7f, 2f);
    }

    void EffectController()
    {

    }
}
