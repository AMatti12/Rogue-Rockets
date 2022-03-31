using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreAdder : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;

    [SerializeField] public int currentScore = 0;

    public void Start()
    {
        scoreText.text = currentScore.ToString();        
    }

    
}

/*



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreAdder : MonoBehaviour
{
    public static int score = 0;
    //TextMeshProUGUI scoreText;
    //[SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        score = 0;
        //scoreText = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}


*/