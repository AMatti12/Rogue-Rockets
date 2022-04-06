﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //required to access various scene functions and properties

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
   {
       int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //find active scene index
       SceneManager.LoadScene(currentSceneIndex + 1); //load next corresponding scene (corresponding index)
   }

    public void LoadStartScene()
   {
       SceneManager.LoadScene(0); //load first scene in build settings sequence
       //FindObjectOfType<GameStatus>().ResetGame();
   }

    public void QuitGame()
    {
        Application.Quit(); //quit game completely
    }
}