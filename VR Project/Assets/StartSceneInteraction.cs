using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartSceneInteraction : MonoBehaviour
{

    public void LoadMainScene()
    {
        XRController left_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        XRController right_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];
        left_controller.GetComponent<XRController>().SendHapticImpulse(0.7f, 1f);
        right_controller.GetComponent<XRController>().SendHapticImpulse(0.7f, 1f);
    }
}
