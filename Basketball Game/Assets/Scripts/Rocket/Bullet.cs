using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float speed = 20f; //initial bullet speed is 20
    public int damage = 50; //it does 50 damage to asteroids ONLY
    public Rigidbody2D rb;
    public GameObject impactEffect; //loads bullet particle affect
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null) //if enemy exists
        {
            enemy.TakeDamage(damage); //the enemy takes damage
        }

        Instantiate(impactEffect, transform.position, transform.rotation); //instantiate particle effect for bullet
        Destroy(gameObject); //destroy the bullet
    }
    
}
