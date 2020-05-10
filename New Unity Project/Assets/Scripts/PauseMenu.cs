using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape)) { // if the escape key is pressed
            if (GameIsPaused) { // if gameIsPaused bool is true
                Resume (); // run Resume() method
            } else {
                Pause (); // run Pause() method
            }
        }
    }
    public void Resume () {
        pauseMenuUI.SetActive (false); // Hides the pause menu UI
        Time.timeScale = 1f; //unfreezes time
        GameIsPaused = false; //switches bool
    }

    void Pause () {
        pauseMenuUI.SetActive (true); //Reveals the pause menu UI
        Time.timeScale = 0f; // Freezes time
        GameIsPaused = true; // sets bool to true

    }
    public void LoadMenu () {
        Time.timeScale = 1f; // Unfreezes time
        SceneManager.LoadScene (0); // loads the 0 scene set in the build
    }
    public void QuitGame () {
        Debug.Log ("Quitting");
        Application.Quit (); // shuts down the application
    }
}