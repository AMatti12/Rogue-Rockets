using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookforScore : MonoBehaviour
{
    //ScoreSystem scoreSystem;
    void Start()
    {
    //int currentScoreX = scoreSystem.currentScore;
    //Debug.Log(currentScoreX);
    int points = GetComponent<ScoreSystem>().currentScore;
    Debug.Log(points);
    }
}
