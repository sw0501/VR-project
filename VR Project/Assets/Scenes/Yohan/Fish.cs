using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private float dieTime = 4f;

    [SerializeField]
    private float swimDepth = 2f;

    [SerializeField]
    private float floatSpeed = 1f;

    private float timer = 0f;
    private bool timerFlag = false;

    void Start()
    {
        Vector3 moveEndPoint = transform.position + new Vector3(moveSpeed*dieTime, 0, 0);

        transform.DOMove(moveEndPoint, dieTime);
    }

    void Update()
    {
        if (timerFlag == false)
        {
            if (timer > dieTime)
            {
                Vector3 moveEndPoint = transform.position + new Vector3(0, swimDepth, 0);
                transform.DOMove(moveEndPoint, dieTime);

                Vector3 rootateEndValue = transform.rotation.eulerAngles + new Vector3(180f, 0, 0);
                transform.DORotate(rootateEndValue, swimDepth/ floatSpeed);

                timerFlag = true;
            }
            timer += Time.deltaTime;
        }
    }
}
