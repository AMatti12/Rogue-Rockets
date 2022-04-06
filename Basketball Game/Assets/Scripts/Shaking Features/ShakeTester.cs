using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTester : MonoBehaviour
{
    public ShakeAgain Shaker;
    [SerializeField] public float duration = 1f;
    //public bool boolean = true;
    // Start is called before the first frame update
//apply this to rocket
//add camera object

    //private void OnCollisionEnter2D(Collision2D collision) //requires trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (boolean)
        //{
        Shaker.Shake(duration);
        //Destroy(gameObject);
        
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //Shaker.Shake(duration);
        //}
    }
        

}
