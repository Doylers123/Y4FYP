using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour {
    public void LoadMenu () {
        Time.timeScale = 1f; //sets timescale to 1
        SceneManager.LoadScene (0); // loads build scene 0
    } //LoadMenu
} //End