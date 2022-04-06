using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDeploy : MonoBehaviour
{
    [SerializeField] public GameObject asteroidPrefab; //asteroid prefab will be used from inspector
    [SerializeField] public float respawnTime = 1.0f; //how often it will respawn
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave()); //coroutine used spread task across various frames
    }

    private void spawnEnemy() //the asteroids are considered enemies to the rocket
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject; //instantiate/create object
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }//spawn the asteroid within a random range at a specific x value designated

    // Update is called once per frame

    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy(); //spawn or instantiate the asteroid
        }
    }

}

