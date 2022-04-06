using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //[SerializeField] public int score = 0;
    [SerializeField] public float speed = 10.0f; //initial speed set to 10s
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private bool hasCollided = false; //the object has not collided initially

    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); //get rigid body component
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //set screen bounds
    }
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -screenBounds.x * 2 && hasCollided == false)
        {
            //if the coin goes beyond the screen boundaries, destroy it so we dont clog up space and slow the game down
            Destroy(this.gameObject);
        }
    }

    
    private void OnColliderEnter2D(Collider2D collision)
    {
        //Debug.Log("Hit");
        
        /*
        if (tag == "ScoreCompatible")
        {
        hasCollided = true;
        Destroy(this.gameObject);
        }
        */
    }
    
}
