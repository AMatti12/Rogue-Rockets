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
    [SerializeField] GameObject scoreSparklesVFX;
    [SerializeField] GameObject boostSparklesVFX;
    [SerializeField] GameObject asteroidImpactVFX;
    
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
