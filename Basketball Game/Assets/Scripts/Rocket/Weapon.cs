using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab; //relates to inspector
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //spacebar trigger
        {
            Shoot(); //call on shoot function
            //hasCollided = true;
            //Destroy(this.gameObject);
        }
    }
    //col.gameObject.tag == "BulletCompatible"

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); //instantiate bullet
        GetComponent<AudioSource>().Play(); //play bullet sound
    }
}
