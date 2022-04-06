using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeAgain : MonoBehaviour
{
    Transform _target;
    Vector3 _initialPos;

    //col.transform.position.z = -4;
    //Debug.Log(transform.position);
    //GetComponent<AudioSource>().Play(clip1);
    //gameObject.GetComponent.<AudioSource>().clip = clip1;

    void Start()
    {
        _target = GetComponent<Transform>();
        //GetComponent<AudioSource>().Play();
        _initialPos = _target.localPosition;
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ScoreSystem>().AddToScoreBonus();
        TriggerSparklesVFX();
    }
    */

    float _pendingShakeDuration = 0f;

    public void Shake(float duration)
    {
        if (duration > 0)
        {
            _pendingShakeDuration += duration;
            //GetComponent<AudioSource>().Play(clip2);
        //gameObject.GetComponent.<AudioSource>().clip = clip2;
        }
    }

    bool _isShaking = false; //not shaking

    void Update()
    {
        if (_pendingShakeDuration > 0 && !_isShaking)
        {
            StartCoroutine(DoShake());
            
            //GameObject sparkles = Instantiate(scoreSparklesVFX, transform.position, transform.rotation);
    //Destroy(sparkles, 1f);

        }
    }

    IEnumerator DoShake()
    {
        _isShaking = true;

        //Debug.Log("Hit");
        
        /*
        if (tag == "ScoreCompatible")
        {
        hasCollided = true;
        Destroy(this.gameObject);
        }
        */

        var startTime = Time.realtimeSinceStartup;
        while(Time.realtimeSinceStartup < startTime + _pendingShakeDuration)
        {
            //Destroy(this.gameObject);
            var randomPoint = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), _initialPos.z);
            //GetComponent<AudioSource>().Play();
            _target.localPosition = randomPoint;
            yield return null;
        }

        //= this.GetComponent<Rigidbody2D>();
        //set screen boundaries
        //rb.velocity = new Vector2(-speed, 0); 

        _pendingShakeDuration = 0f;
        //transform.position.x
        _target.localPosition = _initialPos;
        _isShaking = false;
    }
    //Destroy(this.gameObject);
}
