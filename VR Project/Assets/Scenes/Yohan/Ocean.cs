using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Ocean : MonoBehaviour
{
    [SerializeField]
    private float upStartTime = 2f;

    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private float upLenght = 2f;

    private float timer = 0f;
    private bool timerFlag = false;

    // Update is called once per frame
    void Update()
    {
        if (timerFlag == false)
        {
            if (timer > upStartTime)
            {
                Vector3 moveEndPoint = transform.position + new Vector3(0, upLenght, 0);
                transform.DOMove(moveEndPoint, upLenght / moveSpeed);

                timerFlag = true;
            }
            timer += Time.deltaTime;
        }
    }
}
