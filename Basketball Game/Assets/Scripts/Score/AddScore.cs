using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    //[SerializeField] GameObject scoreSparklesVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(tag == "ScoreCompatible")
        {
        FindObjectOfType<ScoreSystem>().AddToScore();
        GetComponent<AudioSource>().Play();
        TriggerSparklesVFX();
        }
    }

    public void TriggerSparklesVFX()
    {
        if (tag == "ScoreCompatible")
        {
        //GameObject sparkles = Instantiate(scoreSparklesVFX, transform.position, transform.rotation);
        //Destroy(sparkles, 1f);
        }
    }
}
