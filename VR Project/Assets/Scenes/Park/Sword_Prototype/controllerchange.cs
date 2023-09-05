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
    public GameObject prefab_CFC;
    public GameObject prefab_HFC;
    public GameObject prefab_Hand;

    public bool status;

    // Start is called before the first frame update
    void Start()
    {
        status = false ;
        //ControllerPrefabChange("Hand");
    }

    public void ControllerPrefabChange(string name)
    {
        Destroy(spawnedController);
        switch (name){
            case "Hand":
                Destroy(spawnedController);
                spawnedController = Instantiate(prefab_Hand, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
                break;
            case "CFC":
                Destroy(spawnedController);
                spawnedController = Instantiate(prefab_CFC, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
                break;
            case "HFC":
                Destroy(spawnedController);
                spawnedController = Instantiate(prefab_HFC, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
                break;
        }
        spawnedController.tag = "GameController";
    }
}
