﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    LevelLoader LevelLoader;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        LevelLoader.LoadNextLevel();
    }

    

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Test");
    }
}