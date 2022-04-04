using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimPos : MonoBehaviour
{
    public Vector2 rimPos;
    public float rimPosY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rimPos = FindObjectOfType<NetPos>().netPos;
        transform.position = rimPos;
    }
}
