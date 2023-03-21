using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(x, 0f, z).normalized;
        //Vector3 move = transform.right * x + transform.forward * z;
        if(move.magnitude >= 0.1f)
        {
            controller.Move(move * speed * Time.deltaTime);
        }
    }
}
