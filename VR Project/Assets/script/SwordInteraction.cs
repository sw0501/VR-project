using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwordInteraction : MonoBehaviour
{
    public XRController controller;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Sword Collide");
        controller.SendHapticImpulse(0.7f, 2f);
    }
}
