using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostDeploy : MonoBehaviour
{
    public GameObject boostPrefab; //boost prefab corresponding to inspector
    [SerializeField] public float respawnTime = 4.0f; //respawn time set to 4s
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(boostWave());
        //set screen boundaries and use coroutine to spawn multiple objects at a time over multiple frames
    }

    private void spawnBoost()
    {
        GameObject a = Instantiate(boostPrefab) as GameObject; //create boost object
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
        //spawn the boost object within a specific domain I chose but at a random range
    }

    // Update is called once per frame

    IEnumerator boostWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBoost(); //spawn boost (same script used from asteroid deploy)
        }
    }

}

