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
    private float floatSpeed = 1f;


    private Transform waterTransform;
    private float swimDepth = 2f;

    private float timer = 0f;
    private bool timerFlag = false;

    void Start()
    {
        Vector3 moveEndPoint = transform.position + (transform.forward * moveSpeed * dieTime);

        transform.DOMove(moveEndPoint, dieTime);

        waterTransform = GameObject.FindGameObjectWithTag("Water").transform;
    }

    void Update()
    {
        if (timerFlag == false)
        {
            if (timer > dieTime)
            {
                swimDepth = waterTransform.position.y - transform.position.y + 1;
                Vector3 moveEndPoint = transform.position + new Vector3(0, swimDepth, 0);
                transform.DOMove(moveEndPoint, dieTime);

                Vector3 rootateEndValue = transform.rotation.eulerAngles + new Vector3(0, 0, 180f);
                float dieDuration = swimDepth / floatSpeed * 0.6f;
                if (dieDuration > 1f)
                {
                    dieDuration = 1f;
                }
                transform.DORotate(rootateEndValue, dieDuration);

                GetComponent<Animator>().enabled = false;

                timerFlag = true;
            }
            timer += Time.deltaTime;
        }
    }
}
