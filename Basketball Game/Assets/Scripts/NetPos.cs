using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 netPos = new Vector2(transform.position.x, Random.Range(8f, 2f));
        transform.position = netPos;
    }

}
