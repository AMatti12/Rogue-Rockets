using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostDeploy : MonoBehaviour
{
    public GameObject boostPrefab;
    public float respawnTime = 4.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(boostWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(boostPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    // Update is called once per frame

    IEnumerator boostWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

}

