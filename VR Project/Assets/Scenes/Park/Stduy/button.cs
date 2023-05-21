using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject Trigger_Cube;
    bool opendoor;
    // Start is called before the first frame update
    void Start()
    {
        opendoor= false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //고정 초당 60번
    private void FixedUpdate()
    {
        if (opendoor)
        {
            float x = Trigger_Cube.transform.position.x;
            float y = Trigger_Cube.transform.position.y;
            float z = Trigger_Cube.transform.position.z;
            Trigger_Cube.GetComponent<Transform>().position = new Vector3(x + 0.01f,y,z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Trigger_Cube.SetActive(true);
            Trigger_Cube.GetComponent<Trigger>().enabled = true;
            opendoor= true;
        }
    }
}
