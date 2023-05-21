using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject Light;
    public bool isLighton;

    // Start is called before the first frame update
    void Start()
    {
        isLighton= true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Light.gameObject.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        isLighton= !isLighton;
        Light.gameObject.SetActive(isLighton);
    }

    public void LightChange(bool tf)
    {
        //isLighton = !isLighton;
        Light.gameObject.SetActive(tf);
    }

}
