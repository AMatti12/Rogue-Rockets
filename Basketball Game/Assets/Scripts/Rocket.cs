using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public int maxhealth = 4;
    public int currenthealth;

    public HealthBar healthBar;
    public CoinAudio coinAudio;

    [SerializeField] GameObject scoreSparklesVFX;
    [SerializeField] GameObject boostSparklesVFX;
    [SerializeField] GameObject asteroidImpactVFX;

    //public AudioClip clip1;
    //public AudioClip clip2;
    //public AudioClip clip3;

    //public AudioSource sourceAsteroid;
    //public AudioSource sourceCoin;
    //public AudioSource sourceBoost;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Rocket collision with: " + col.gameObject.name);
        
    if (col.tag == "BoostCompatible")
    {
        var effectPosition1 = col.transform.position;
        //effectPosition.transform.position = new Vector3(effectPosition.x, effectPosition.y, -4.0f);
        //effectPosition.position.z = -4.0f;
        Debug.Log(effectPosition1);
        //col.transform.position.z = -4;
        //Debug.Log(transform.position);
        //GetComponent<AudioSource>().Play(clip1);
        //gameObject.GetComponent.<AudioSource>().clip = clip1;
        GameObject boost = Instantiate(boostSparklesVFX, effectPosition1, transform.rotation);
        Destroy(col.gameObject);
        currenthealth += 1;
        if(currenthealth > 4)
        {
            currenthealth = 4;
            healthBar.SetHealth(currenthealth);
        }
        else
        {
            healthBar.SetHealth(currenthealth);
        }

    }
    else if (col.tag == "ScoreCompatible")
    {
        var effectPosition2 = col.transform.position;
        GameObject coin = Instantiate(scoreSparklesVFX, effectPosition2, transform.rotation);
        //GetComponent<AudioSource>().Play();
        //coinAudio.PlayAudio();
        FindObjectOfType<ScoreSystem>().AddToScore();
        //AudioSource.PlayOneShot (clip1, 1.0f);
        Debug.Log(col);
        Destroy(col.gameObject);
    }
    else if (col.tag == "AsteroidCompatible")
    {
        var effectPosition3 = col.transform.position;
        
        GameObject coin = Instantiate(asteroidImpactVFX, effectPosition3, transform.rotation);
        Destroy(col.gameObject);
        TakeDamage(1);
    }
    }

    void Start()
    {
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        //sourceAsteroid = gameObject.AddComponent<AudioSource>();
        //sourceBoost = gameObject.AddComponent<AudioSource>();
        //sourceCoin = gameObject.AddComponent<AudioSource>();
    }

    void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
        healthBar.SetHealth(currenthealth);
        
    }

    

}
