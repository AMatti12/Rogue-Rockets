using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTester : MonoBehaviour
{
    public ShakeAgain Shaker;
    public float duration = 1f;
    //public bool boolean = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        //if (boolean)
        //{
        Shaker.Shake(duration);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Shaker.Shake(duration);
        //}
        
    }
}
