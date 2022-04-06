using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        SceneLoader sceneloader = FindObjectOfType<SceneLoader>(); //find sceneloader
        //Debug.Log(sceneloader);
        //if (tag == "Discontinuity")
        //{
            sceneloader.LoadNextScene(); //load on TRIGGER
        //}
    }

}
