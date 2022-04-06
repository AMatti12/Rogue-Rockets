using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDeploy : MonoBehaviour
{
    public GameObject coinPrefab; //will use coin prefab from inspector
    [SerializeField] public float respawnTime = 4.0f; //will respawn every 4s
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(coinWave()); //spawn multiple coins!
    }

    private void spawnCoin()
    {
        GameObject a = Instantiate(coinPrefab) as GameObject; //create actual coin game object
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
        //set coin game object to spawn at random range
    }

    // Update is called once per frame

    IEnumerator coinWave()
    {
        while (true) //continue looping while waiting for respawn time
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin(); //spawn coins
        }
    }
}
