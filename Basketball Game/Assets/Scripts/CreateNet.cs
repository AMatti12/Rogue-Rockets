using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNet : MonoBehaviour
{
    public GameObject netPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(netWave());
    }

    private void spawnNet()
    {
        GameObject a = Instantiate(netPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    // Update is called once per frame
    IEnumerator netWave(){
        while (true) {
            yield return new WaitForSeconds(respawnTime);
        spawnNet();
        }
    }
    void Update()
    {
        
    }
}
