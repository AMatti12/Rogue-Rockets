using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreGameObj : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreAdder.score++;
    }
}
