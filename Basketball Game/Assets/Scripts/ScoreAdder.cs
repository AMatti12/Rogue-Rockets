using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreAdder : MonoBehaviour
{
    public static int score = 0;

    private void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Game Over"); //game over message when the ball hits the lose collider volume
    }

    private void Update()
    {
        GetComponent<Unityengine.UI.Text>().text = score;
    }
}