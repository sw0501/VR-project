using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartSceneInteraction : MonoBehaviour
{
    public AudioManager audioManager;

    /*
    IEnumerator BirdsSound()
    {
        /*
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            this.GetComponent<Image>().color = new Color(0, 0, 0, fadeCount);

        }

        Destroy(GameObject.FindWithTag("Player"));

        SceneManager.LoadScene(1);
        
    }
    */

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
}
