using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensibility = 80f;
    public Transform playerBody;
    float rotation = 0;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime;

        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
