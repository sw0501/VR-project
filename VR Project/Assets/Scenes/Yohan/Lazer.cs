using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float extendStartTime = 2f;

    [SerializeField]
    private float extendSpeed = 4f;

    [SerializeField]
    private float maxLenght = 20f;

    private float timer = 0f;
    private bool timerFlag = false;

    void Update()
    {
        if (timerFlag == false)
        {
            if (timer > extendStartTime)
            {
                Vector3 extendEndScale = transform.localScale + new Vector3(0, maxLenght, 0);
                transform.DOScale(extendEndScale, maxLenght / extendSpeed);

                Vector3 moveEndPoint = transform.position + new Vector3(0, -maxLenght, 0);
                transform.DOMove(moveEndPoint, maxLenght / extendSpeed);

                timerFlag = true;
            }
            timer += Time.deltaTime;
        }
    }
}
