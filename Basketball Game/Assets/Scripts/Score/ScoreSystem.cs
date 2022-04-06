using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; //to use integrated scene related functions


public class ScoreSystem : MonoBehaviour
{


    [SerializeField] public int currentScore = 0; //current score is 0
    [SerializeField] int pointsPerTrigger = 2; //2 points are given per trigger
    [SerializeField] TextMeshProUGUI scoreText;
    //FinalScoreText finalScore;
    //[SerializeField] GameObject scoreSparklesVFX;
    //public void LoadGame (string input)
   // {
        //SceneManager.LoadScene(2);
    //}

    private void Awake()
    {
        int scoreSystemCount = FindObjectsOfType<ScoreSystem>().Length;
        if (scoreSystemCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }



    private void Start()
    {
        scoreText.text = currentScore.ToString();
        GetComponent<AudioSource>().Play();
        
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
        scoreText.text = currentScore.ToString();


        //Scene scene = SceneManager.GetActiveScene();
        //if (scene.name == "Game Over Scene") {
           // int currentScore = GameObject.Find("Score System").GetComponent<ScoreSystem>().currentScore;
           // scoreText.text = currentScore.ToString();
        //}
         //change Ui text to show the user
        //Debug.Log(currentScore);
        //if (currentScore >= 10) //if the user exceeds 10
        //{
            //scoreText.text = "10"; //output
            //FindObjectOfType<SceneLoader>().LoadNextScene(); //load next scene
            //SceneManager.LoadNextScene();
        //}
        //return currentScore;
        
        //finalScore.GetPoints();
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

    public string returnScore() {
        string currentScoreAsString = currentScore.ToString();
        return currentScoreAsString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
