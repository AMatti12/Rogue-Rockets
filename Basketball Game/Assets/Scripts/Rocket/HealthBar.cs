using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //required for text output to user

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider; //UI slider
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; //set max value to the current health
        slider.value = health;
        //OnCollisionEnter2D(Collision2D col)
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        //col.gameObject.tag == "ScoreCompatible"
    }
}
