using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    [SerializeField] public GameObject impactEffect;

    void OnCollisionEnter2D (Collision2D variable)
    {
        //Instantiate(impactEffect, transform.position, transform.rotation);
    }
}
