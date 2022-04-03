using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScore : MonoBehaviour
{
    [SerializeField] GameObject scoreSparklesVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ScoreSystem>().AddToScoreBonus();
        TriggerSparklesVFX();
    }

    public void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(scoreSparklesVFX, transform.position, transform.rotation);
        //Destroy(sparkles, 1f);
    }
    
}
