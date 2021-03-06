using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompatibleBehaviour : MonoBehaviour
{
    [SerializeField] public int score = 0;
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private bool hasCollided = false;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -screenBounds.x * 2 && hasCollided == false)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tag == "ScoreCompatible")
        {
        hasCollided = true;
        Destroy(this.gameObject);
        }
    }
}
