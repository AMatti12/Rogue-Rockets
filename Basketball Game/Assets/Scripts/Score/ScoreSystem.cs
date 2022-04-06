using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; //to use integrated scene related functions


public class ScoreSystem : MonoBehaviour
{


    [SerializeField] int currentScore = 0; //current score is 0
    [SerializeField] int pointsPerTrigger = 2; //2 points are given per trigger
    [SerializeField] TextMeshProUGUI scoreText;
    //[SerializeField] GameObject scoreSparklesVFX;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }
/*
    private void Awake()
    {
        int scoreStatusCount = FindObjectsOfType<ScoreSystem>().Length;
        if (scoreStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }

*/

    public void AddToScore()
    {
        currentScore += pointsPerTrigger; //award points to user
        scoreText.text = currentScore.ToString(); //change Ui text to show the user
        if (currentScore >= 10) //if the user exceeds 10
        {
            scoreText.text = "10"; //output
            FindObjectOfType<SceneLoader>().LoadNextScene(); //load next scene
            //SceneManager.LoadNextScene();
        }
    }

    public void AddToScoreBonus()
    {
        //currentScore += 10;
        //scoreText.text = currentScore.ToString();
    }
    /*
    public void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(scoreSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
