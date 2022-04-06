using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ScoreSystem : MonoBehaviour
{


    [SerializeField] int currentScore = 0;
    [SerializeField] int pointsPerTrigger = 2;
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
        currentScore += pointsPerTrigger;
        scoreText.text = currentScore.ToString();
        if (currentScore >= 10)
        {
            scoreText.text = "10";
            FindObjectOfType<SceneLoader>().LoadNextScene();
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
