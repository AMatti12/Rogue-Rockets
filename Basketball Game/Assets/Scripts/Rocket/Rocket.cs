using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    [SerializeField] public int maxhealth = 4; //max health is 4
    public int currenthealth;

    public HealthBar healthBar;
    public CoinAudio coinAudio;
    public BoostAudio boostAudio;
    public AsteroidAudio asteroidAudio;

      //public AudioClip clip1;
    //public AudioClip clip2;
    //public AudioClip clip3;

    [SerializeField] GameObject scoreSparklesVFX;
    [SerializeField] GameObject boostSparklesVFX;
    [SerializeField] GameObject asteroidImpactVFX;

    //public AudioSource sourceAsteroid;
    //public AudioSource sourceCoin;
    //public AudioSource sourceBoost;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Rocket collision with: " + col.gameObject.name);

        /*
if(Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }

        */
        
    if (col.tag == "BoostCompatible") //pertains to boost
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
        boostAudio = FindObjectOfType<BoostAudio>();
        boostAudio.PlayAudio();
        //GetComponent<AudioSource>().Play(clip2);
        //gameObject.GetComponent.<AudioSource>().clip = clip2;
        Destroy(col.gameObject);
        currenthealth += 1;
        if(currenthealth > 4) //cant have health greater than 4
        {
            currenthealth = 4;
            healthBar.SetHealth(currenthealth); //make sure the bars output to the user corresponds to actual health value
        }
        else
        {
            healthBar.SetHealth(currenthealth); //if it isnt greater than 4, act normally
        }

    }
    else if (col.tag == "ScoreCompatible") //pertains to coin
    {
        var effectPosition2 = col.transform.position;
        GameObject coin = Instantiate(scoreSparklesVFX, effectPosition2, transform.rotation);
        //GetComponent<AudioSource>().Play();

        coinAudio = FindObjectOfType<CoinAudio>();
        coinAudio.PlayAudio();

        FindObjectOfType<ScoreSystem>().AddToScore();
        //AudioSource.PlayOneShot (clip1, 1.0f);
        Debug.Log(col);
        Destroy(col.gameObject);
    }
    else if (col.tag == "AsteroidCompatible") //pertains to asteroid
    {
        var effectPosition3 = col.transform.position;
        /*
        if (transform.position.x < -screenBounds.x * 2 && hasCollided == false)
        {
            Destroy(this.gameObject);
        }
        */
        GameObject coin = Instantiate(asteroidImpactVFX, effectPosition3, transform.rotation);
        asteroidAudio = FindObjectOfType<AsteroidAudio>();
        asteroidAudio.PlayAudio();
        Destroy(col.gameObject);
        TakeDamage(1);
        //asteroidAudio = FindObjectOfType<AsteroidAudio>();
        //asteroidAudio.PlayAudio();
        
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
        currenthealth -= damage; //subtract damage from current health
        if (currenthealth <= 0) //if the rocket is dead
        {
            SceneManager.LoadScene(5); //load the following scene
        }
        healthBar.SetHealth(currenthealth); //chaneg current health value
        
    }

    

}
