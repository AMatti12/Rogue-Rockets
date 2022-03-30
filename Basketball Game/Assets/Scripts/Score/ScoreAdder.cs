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

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}