using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    /*
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
        transform.position = viewPos;
    }
    */
    void Update()
    {
        if (transform.position.y >= 4.20f)
        {
            transform.position = new Vector3(transform.position.x, 4.20f, 0f);
            //-5.5
            //4.20 is max y value
        }
        else if (transform.position.y <= -4.60f)
        {
            //-4.60 is min y value
            transform.position = new Vector3(transform.position.x, -4.60f, 0f);
        }

        if (transform.position.x <= -7.3f)
        {
            //-7.3 is min x value
            transform.position = new Vector3(-7.3f, transform.position.y, 0f);
        }

        if (transform.position.x >= 7.5f)
        {
            //7.5 is max x value
            //if object reaches that height/length, change its position to that objects health/length is equal to the
            //set height/length so it cant go beyond it
            transform.position = new Vector3(7.5f, transform.position.y, 0f);
        }
    }
}
