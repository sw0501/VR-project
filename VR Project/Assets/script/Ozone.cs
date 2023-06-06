using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Ozone : MonoBehaviour
{
    private GameObject player;

    [SerializeField]
    private float moveDuration = 1f;
    [SerializeField]
    private float playerDistance = 1.5f;
    [SerializeField]
    private float maxHeight = 3f;

    private AudioManager audioManager;

    private UIManager uiManager;

    private XRController left_controller;
    private XRController right_controller;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        audioManager.PlaySFX("CreateOZ");
        left_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        right_controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];

    }

    private void OnMouseDown()
    {
        uiManager.IncreaseGaugeValue();
        transform.DOKill();
        gameObject.SetActive(false);
        audioManager.PlaySFX("DestroyOZ");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GameController")
        {
            uiManager.IncreaseGaugeValue();
            transform.DOKill();
            gameObject.SetActive(false);
            audioManager.PlaySFX("DestroyOZ");
            right_controller.SendHapticImpulse(0.7f, 0.5f);
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //TODO 검과 충돌하면 제거 및 점수처리
    }

    private Vector3 GetDirectionVector(Vector3 startPosition, Vector3 targetPosition)
    {
        Vector3 direction = targetPosition - startPosition;
        direction.Normalize();

        return direction;
    }

    private float GetDistance(Vector3 positionA, Vector3 positionB)
    {
        float distance = Vector3.Distance(positionA, positionB);
        return distance;
    }

    private void MoveObject(Vector3 moveDirection, float moveDistance)
    {
        Vector3 targetPosition = transform.position + moveDirection * moveDistance;
        transform.DOMove(targetPosition, moveDuration).SetEase(Ease.Linear);
    }

    public void MoveObject()
    {
        GameObject moveTarget = new GameObject();

        moveTarget.transform.position = player.transform.position;

        moveTarget.transform.position = new Vector3(player.transform.position.x,
            player.transform.position.y + Random.Range(-maxHeight / 2, maxHeight / 2),
            player.transform.position.z);

        MoveObject(GetDirectionVector(transform.position, moveTarget.transform.position)
            , GetDistance(transform.position, moveTarget.transform.position) - playerDistance);
    }
}
