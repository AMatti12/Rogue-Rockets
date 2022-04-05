using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{     void OnCollisionEnter(Collision col)
  {
      Debug.Log("Collision");
    
      if (col.gameObject.tag == "ScoreCompatible" || col.gameObject.tag == "AsteroidCompatible" || col.gameObject.tag == "BoostCompatible" || col.gameObject.tag == "BulletCompatible")
      {
        Debug.Log("should ignore");
        //Physics2D.IgnoreCollision(collision.GetComponent<Collider2D>(), GetComponent<Collider2D>());
      }
     
}
}
