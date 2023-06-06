using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


public class EndSceneInteraction : MonoBehaviour
{
    public AudioManager audioManager;

    IEnumerator RetryCoroutine()
    {
        GameObject Panel = GameObject.FindGameObjectWithTag("Panel");

        Destroy(GameObject.FindGameObjectWithTag("AudioManager"));
        Destroy(GameObject.FindGameObjectWithTag("GameManager"));
        Destroy(GameObject.FindGameObjectWithTag("FSMManager"));
        Destroy(GameObject.FindGameObjectWithTag("PlayerManager"));
        Destroy(GameObject.FindGameObjectWithTag("UIManager"));

        Panel.GetComponent<FadeOut>().FadeOutFunc(0);

        yield return new WaitForSeconds(5f);

        

        SceneManager.LoadScene(0);

    }

    public void Awake()
    {
        //audioManager = (AudioManager)GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
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

    public void Retry()
    {
        StartCoroutine(RetryCoroutine());
    }

    public void GameOver()
    {
        Debug.Log("종료1");
        Application.Quit();
        Debug.Log("종료2");
    }
}
