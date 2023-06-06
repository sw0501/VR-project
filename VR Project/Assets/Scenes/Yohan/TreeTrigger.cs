using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTrigger : MonoBehaviour
{
    bool triggerFlag = false;


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
        if (triggerFlag)
        {
            if (other.gameObject.tag == "Tree")
            {
                Debug.Log("나무 바꾸자~!");
                other.gameObject.GetComponent<TreeColorChanger>().triggerStart = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.tag == "Lazer")
        {
            triggerFlag = true;
            Debug.Log("레이져 충돌!");
        }
    }
}
