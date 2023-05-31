using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class controllerchange : MonoBehaviour
{

    // 플레이어 눈에 보이는 게임오브젝트
    private GameObject spawnedController;
    public XRController controller;
    public GameObject prefab;
    public GameObject prefab2;

    public bool status = false;

    // Start is called before the first frame update
    void Start()
    {
        status = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(status);
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            if (status)
            {
                Destroy(spawnedController);
                spawnedController = Instantiate(prefab, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
            }
            else
            {
                Destroy(spawnedController);
                spawnedController = Instantiate(prefab2, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
            }
        }
    }
}
