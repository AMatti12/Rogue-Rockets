using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScoreGameObj : MonoBehaviour
{
    //ScoreAdder scoreX = FindObjectOfType<ScoreAdder>();
    //public static Object[] FindObjectsOfType(Type type);
   public static List<ScoreAdder> scoreX = FindObjectsOfType<ScoreAdder>();


private void Update()
{
    Debug.Log(scoreX.Length());
}
private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(scoreX.currentScore);
        //scoreX.scoreText.text = scoreX.currentScore.ToString();
    }

}