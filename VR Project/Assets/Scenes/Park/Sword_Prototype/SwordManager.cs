using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SwordManager : MonoBehaviour
{
    public GameObject ControllerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collide");
        //컨트롤러와 충돌해 있고 Space 버튼 (나중에 컨트롤러 Grab 버튼으로 변경)
        if(other.tag == "GameController" && Input.GetKeyDown(KeyCode.Space))
        {
            ControllerPrefab.GetComponent<controllerchange>().status = true;

            
            /*
            Debug.Log("Parent");
            this.transform.SetParent(other.transform);
            this.transform.position = new Vector3(0, 0, 3);
            */

        }
        
    }


}
