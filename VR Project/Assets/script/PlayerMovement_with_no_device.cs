using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_with_no_device : MonoBehaviour
{
    private float xRotate, yRotate, xRotateMove, yRotateMove;
    public float rotateSpeed = 500.0f;

    public float speed = 10f;
    public float moveSpeed = 5f;

    public float sensitivity = 100f;

    void Update()
    {
        //Player Rotate
        if (Input.GetMouseButton(0)) // 클릭한 경우
        {
            xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
            yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

            yRotate = transform.eulerAngles.y + yRotateMove;
            //xRotate = transform.eulerAngles.x + xRotateMove; 
            xRotate = xRotate + xRotateMove;

            xRotate = Mathf.Clamp(xRotate, -90, 90); // 위, 아래 고정

            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }

        //Player Move
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize();

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);

        
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
