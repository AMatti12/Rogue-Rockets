using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] GameObject scoreSparklesVFX;
    [SerializeField] GameObject boostSparklesVFX;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Here");
    if (col.tag == "BoostCompatible")
    {
        var effectPosition1 = col.transform.position;
        //effectPosition.transform.position = new Vector3(effectPosition.x, effectPosition.y, -4.0f);
        //effectPosition.position.z = -4.0f;
        Debug.Log(effectPosition1);
        //col.transform.position.z = -4;
        //Debug.Log(transform.position);
        GameObject boost = Instantiate(boostSparklesVFX, effectPosition1, transform.rotation);
        Destroy(col.gameObject);
    }
    else if (col.tag == "ScoreCompatible")
    {
        var effectPosition2 = col.transform.position;
        GameObject coin = Instantiate(scoreSparklesVFX, effectPosition2, transform.rotation);
        Destroy(col.gameObject);
    }
    }

}
