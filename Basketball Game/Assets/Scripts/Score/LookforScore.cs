using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LookforScore : MonoBehaviour
{
    
    //ScoreSystem scoreSystem;
    [SerializeField] TextMeshProUGUI scoreOutputText;
    int points;
    string pointsAsString;
    void Start()
    {
    //int currentScoreX = scoreSystem.currentScore;
    //Debug.Log(currentScoreX);
    points = GameObject.Find("ScoreSystem").GetComponent<ScoreSystem>().currentScore;
    //pointsAsString = points.ToString();
    //Debug.Log(points);
    pointsAsString = points.ToString();
    scoreOutputText.text = pointsAsString;
    }
}
