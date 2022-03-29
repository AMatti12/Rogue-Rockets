using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    //private BallJump_Base ballBase;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 500f;
            try {
                rb.velocity = Vector2.up * jumpVelocity;
                Debug.Log("Try successful");
            } catch {
                Debug.Log("Failed");
            }

            //transform.Translate(0,0,2);
            

        }
    }
}
