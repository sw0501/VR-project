using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSword : MonoBehaviour
{
    //나중에 주 손으로 사용할 컨트롤러에다 검 구현
    public GameObject Sword_Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        Sword_Prefab.SetActive(true);
    }
}
