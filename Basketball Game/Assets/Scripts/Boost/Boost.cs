using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField] public float speed = 10.0f; //set initial speed to 10
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private bool hasCollided = false; //the object has not collided initially

    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //= this.GetComponent<Rigidbody2D>();
        //set screen boundaries
        //rb.velocity = new Vector2(-speed, 0);    
    }
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -screenBounds.x * 2 && hasCollided == false)
        {
            //if the boost object is off the screen, destroy it
            Destroy(this.gameObject);
        }
    }

    /*

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tag == "BoostCompatible")
        {
        hasCollided = true;
        Destroy(this.gameObject);
        }
    }

    */
    
}
