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
        Destroy(col.gameObject);
        GameObject boost = Instantiate(boostSparklesVFX, transform.position, transform.rotation);
    }
    else if (col.tag == "ScoreCompatible")
    {
        Destroy(col.gameObject);
        GameObject coin = Instantiate(scoreSparklesVFX, transform.position, transform.rotation);
    }
    }

}
