using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class LoadSceneCS : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        
        if (other.tag == "GameController")
        {
            Debug.Log("asdfa");
            other.GetComponentInParent<XRController>().SendHapticImpulse(0.7f, 0.5f);
            Destroy(GameObject.FindWithTag("Light"));
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene(1);

        }
    }

}
