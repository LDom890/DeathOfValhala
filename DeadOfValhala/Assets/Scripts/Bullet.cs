using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 5.0F;
    public Rigidbody rb;

    

    private void OnCollisionStay(Collision other)
    {
        Vector3 explosionPos = transform.position;
       
        rb.AddExplosionForce(power, explosionPos, radius, 3.0F);

    }
}
