using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartSceneInteraction : MonoBehaviour
{

    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject fadeout;


    IEnumerator Aircondition()
    {
        particle1.SetActive(true); 
        particle2.SetActive(true);
        particle3.SetActive(true);

        yield return new WaitForSeconds(2f);

        fadeout.SetActive(true);
        fadeout.GetComponent<FadeOut>().FadeOutFunc(1);

    }

    public AudioManager audioManager;

    public void Awake()
    {
        audioManager = (AudioManager)GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void Start()
    {
        ActivateHaptic(1f);
        audioManager.PlaySFX("Birds");
    }

    public void ActivateHaptic(float duration)
    {
        XRController left_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        XRController right_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];
        left_controller.GetComponent<XRController>().SendHapticImpulse(0.7f, duration);
        right_controller.GetComponent<XRController>().SendHapticImpulse(0.7f, duration);
    }

    public void ActivateAirCondition()
    {
        StartCoroutine(Aircondition());
    }
}
