using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class testsaf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene(1);
        }

    }

    public void LoadMainScene()
    {
        XRController left_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        XRController right_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];
        left_controller.GetComponent<XRController>().SendHapticImpulse(0.7f, 1f);
        right_controller.GetComponent<XRController>().SendHapticImpulse(0.7f, 1f);
        Destroy(GameObject.FindWithTag("Player"));
        SceneManager.LoadScene(1);
    }
}
