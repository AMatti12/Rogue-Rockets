using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreSystem scoreSystem;
    // Start is called before the first frame update
    public void GetPoints()
    {
        //ScoreSystem receivedPoints = scoreSystem.currentScore;
       // scoreText.text = receivedPoints.ToString();
    }
}
