using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyManager : MonoBehaviour
{
    private int health = 3;
    GameObject ennemyboat;
    private void Start()
    {
        ennemyboat = this.gameObject;
    }
    private void OnCollisionEnter(Collision other)
    {
        health--;
        Debug.Log("Collision");

        if (health <=0)
        { Destroy(ennemyboat); }
    }
}
