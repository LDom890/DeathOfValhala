using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    Rigidbody rb;

    public float shotForce = 1500;
    public float recoilForce = 20f;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;


    public void Update()
    {
        Fire();
    }
   public void Fire()
    {
        if (Input.GetKey("Space"))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                shotRateTime = Time.time + shotRate;
                Destroy(newBullet, 2);
                rb.AddForce(transform.TransformPoint(Vector3.forward) * recoilForce);
            }
        }
       
    }
}
