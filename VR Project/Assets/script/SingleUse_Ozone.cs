using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleUse_Ozone : MonoBehaviour
{
    private GameObject player;

    [SerializeField]
    private float moveDuration = 1f;
    [SerializeField]
    private float playerDistance = 1.5f;
    [SerializeField]
    private float maxHeight = 3f;

    private AudioManager audioManager;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    private void OnMouseDown()
    {
        transform.DOKill();
        gameObject.SetActive(false);
        audioManager.PlaySFX("DestroyOZ");
    }

    private void OnCollisionEnter(Collision collision)
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
