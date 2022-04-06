using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int health = 100; //the asteroids health will be set at 100

    public GameObject deathEffect; //calling on the asteroid particle affect

    public void TakeDamage (int damage)
    {
        health -= damage; //subtract damage

        if (health <= 0)
        {
            Die(); //if health is equal to 0 or less, call on die method
        }
    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity); //creates particle effect
        Destroy(gameObject); //destroys asteroid/enemy 
    }
}
