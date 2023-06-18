using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class changeLR : MonoBehaviour
{

    private GameObject spawnedController;
    public XRController controller;
    public GameObject hand;
    public GameObject remote;

    public bool status;

    void Start()
    {
        status = false;

        if (this.gameObject.name.Contains("Right"))
        {
            ControllerPrefabChange("remote");
        }
        else
        {
            ControllerPrefabChange("hand");
        }
        
    }

    // Start is called before the first frame update
    public void ControllerPrefabChange(string name)
    {
        Destroy(spawnedController);
        controller.GetComponent<XRController>().modelPrefab = null;
        controller.GetComponent<XRController>().modelParent = null;
        controller.GetComponent<XRController>().model = null;

        switch (name)
        {
            case "hand":
                Destroy(spawnedController);
                spawnedController = Instantiate(hand, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
                break;
            case "remote":
                Destroy(spawnedController);
                spawnedController = Instantiate(remote, transform);
                controller.GetComponent<XRController>().modelPrefab = spawnedController.transform;
                break;
        }
        spawnedController.tag = "GameController";
    }
}
