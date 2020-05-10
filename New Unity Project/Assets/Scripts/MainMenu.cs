using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); // loads the next scene in the build

    }

    public void LevelOne () {
        SceneManager.LoadScene (1); // loads scene 1 of the build
    }

    public void LevelTwo () {
        SceneManager.LoadScene (2); // loads scene 2 of the build
    }

    public void LevelThree () {
        SceneManager.LoadScene (3); // loads scene 3 of the build
    }

    public void QuitGame () {
        Application.Quit (); //Shuts down the application
        Debug.Log ("Test");
    }
}