using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] public float speed = 10.0f; //initializing speed
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); //Get rigid body component to tune velocity
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    } //finding screen boundaries
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -screenBounds.x * 2) //if tthe objects x position is less than the screen bounds * 2
        {   //if the asteroid goes beyond the screens boundaries, destroy it.
            Destroy(this.gameObject);
        }
    }

    
}
