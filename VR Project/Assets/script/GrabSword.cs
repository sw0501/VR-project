using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;
//using UnityEngine.InputSystem.XR;

public class GrabSword : MonoBehaviour
{
    //나중에 주 손으로 사용할 컨트롤러에다 검 구현
    public GameObject Sword_Prefab;
    public GameObject GameManager;
    public GameObject newPrefab;    // 새로운 컨트롤러 프리팹을 할당합니다.
    public GameObject newPrefab2;    // 새로운 컨트롤러 프리팹을 할당합니다.

    public XRController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.gameObject.SetActive(false);

            // 새로운 프리팹을 인스턴스화하여 컨트롤러에 할당합니다.
            GameObject newModel = Instantiate(newPrefab, controller.transform);
            controller.model = newModel.transform;

            // 컨트롤러를 활성화합니다.
            controller.gameObject.SetActive(true);

            GameManager.GetComponent<GameManager>().isGrabSword = true;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            controller.gameObject.SetActive(false);

            // 새로운 프리팹을 인스턴스화하여 컨트롤러에 할당합니다.
            GameObject newModel = Instantiate(newPrefab, controller.transform);
            controller.model = newModel.transform;

            // 컨트롤러를 활성화합니다.
            controller.gameObject.SetActive(true);

            GameManager.GetComponent<GameManager>().isGrabSword = true;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        Sword_Prefab.SetActive(true);
        GameManager.GetComponent<GameManager>().isGrabSword = true;

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Click");

        controller.gameObject.SetActive(false);

        // 새로운 프리팹을 인스턴스화하여 컨트롤러에 할당합니다.
        GameObject newModel = Instantiate(newPrefab, controller.transform);
        controller.model = newModel.transform;

        // 컨트롤러를 활성화합니다.
        controller.gameObject.SetActive(true);

        GameManager.GetComponent<GameManager>().isGrabSword = true;

        Destroy(this.gameObject);
    }

}
