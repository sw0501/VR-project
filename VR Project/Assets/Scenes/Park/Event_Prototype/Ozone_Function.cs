using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ozone_Function : MonoBehaviour
{
    public UnityEvent EndEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //플레이어와 충돌 시 점수 오르는 이벤트
        if(other.tag == "Player")
        {
            EndEvent.Invoke();
        }
    }
}
