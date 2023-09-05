using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwordInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ozone")
        {
            this.GetComponentInParent<XRController>().SendHapticImpulse(0.7f, 1f);
        }
    }
}
