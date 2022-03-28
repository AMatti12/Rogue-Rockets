using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    private Rigidbody2D rb;
    public const float JumpAmount = 20f;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<RigidBody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (rb = hit.transform.GetComponent<Rigidbody2D>())
                {
                    Jump();
                }
            }
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * JumpAmount;
    }
}
