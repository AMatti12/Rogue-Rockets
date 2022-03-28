using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    private BallJump_Base ballBase;
    private RigidBody2D rigidBody2D
    // Start is called before the first frame update
    private void Awake()
    {
        ballBase = gameObject.GetComponent<BallJump_Base>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 100f;
            rigidBody2D.velocity = Vector2.ip * jumpVelocity
        }
    }
}
