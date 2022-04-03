using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetMove : MonoBehaviour
{

    public float speed = 5f;
    private float leftEdge;
    // Start is called before the first frame update
    private void Start()
    {
        Vector2 netPos = transform.position;
        netPos.y = Random.Range(50f, 650f);
        transform.position = netPos;
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge - 1000)
        {
            Destroy(gameObject);
        }
    }
}
