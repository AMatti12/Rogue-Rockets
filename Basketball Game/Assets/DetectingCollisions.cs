using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
    
        if (col.gameObject.tag == "ScoreCompatible" || col.gameObject.tag == "AsteroidCompatible" || col.gameObject.tag == "BoostCompatible" || col.gameObject.tag == "BulletCompatible")
        {
            Debug.Log("should ignore");
            Physics2D.IgnoreCollision(col.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    } 
}
