using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public AudioSource audio;
    public GameObject player1;
    public GameObject player2;

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public static int p1Health;
    public int p1LifeMax;
    public static int P1CurHealth;
    public int numOfHealth;
    public int p2Health;
    public int p2LifeMax;
    public static int P2CurHealth;

    public GameObject P1Win;
    public GameObject P2Win;

    public Image[] p1Lives;
    public Image[] p2Lives;
    public Sprite full;
    public Sprite empty;

    Countdown countdown;
    Score score;
    ScoreP2 scoreP2;

    // Start is called before the first frame update
    void Start () {
        P1CurHealth = 5; // sets player ones start health
        P2CurHealth = 5; // sets player twos start health
    }

    // Update is called once per frame
    void Update () {
        p1LifeMax = numOfHealth; // max life is the same as number of health/hearts
        p1Health = P1CurHealth; // Player one health is the start health

        p2LifeMax = numOfHealth; // max life is the same as number of health/hearts
        p2Health = P2CurHealth; // Player one health is the start health

        for (int i = 0; i < p1Lives.Length; i++) {
            if (p1Health > numOfHealth) { //if the players health is greater than the number of hearts
                p1Health = numOfHealth; // players health becomes equal to number of hearts
            }

            if (i < p1Health) {
                p1Lives[i].sprite = full;
            } else {
                p1Lives[i].sprite = empty;
            }

            if (i < numOfHealth) {
                p1Lives[i].enabled = true;
            } else {
                p1Lives[i].enabled = false;
            }
            if (p1Health <= 0) {
                Time.timeScale = 0f;// freeze time
                player1.SetActive (false); //hide player
                P2Win.SetActive (true); // p2 win screen activates
                audio.Pause ();// music stops
                p1Health = 5;
            }
        } //for

        for (int i = 0; i < p2Lives.Length; i++) {
            if (p2Health > numOfHealth) {
                p2Health = numOfHealth;
            }

            if (i < p2Health) {
                p2Lives[i].sprite = full;
            } else {
                p2Lives[i].sprite = empty;
            }

            if (i < numOfHealth) {
                p2Lives[i].enabled = true;
            } else {
                p2Lives[i].enabled = false;
            }

            if (p1Health <= 0) {
                Time.timeScale = 0f;
                player1.SetActive (false);
                P2Win.SetActive (true);
                audio.Pause ();
                p1Health = 5;
            }

            if (p2Health <= 0) {
                Time.timeScale = 0f;
                player2.SetActive (false);
                P1Win.SetActive (true);
                audio.Pause ();
                P1CurHealth = 5;
            }

        } // For

        if (Input.GetKeyDown (KeyCode.Escape)) {// if escape key is pressed
            if (GameIsPaused) {// if game is paused is true
                Resume ();// run resume method
            } else {
                Pause ();// Runs pause method
            }
        }

    } //Update

    public void hurtP1 () {
        SoundManager.PlaySound ("Hit");
        P1CurHealth -= 1;

        for (int i = 0; i < p1Lives.Length; i++) {
            if (p1Health > i) {
                p1Lives[i].sprite = full;
            } else {
                p1Lives[i].sprite = empty;
            }
        }
    } //HurtP1

    public void hurtP2 () {
        SoundManager.PlaySound ("Hit");
        P2CurHealth -= 1;

        for (int i = 0; i < p2Lives.Length; i++) {
            if (p2Health > i) {
                p2Lives[i].sprite = full;
            } else {
                p2Lives[i].sprite = empty;
            }
        }
    } //HurtP2

    public void Resume () {
        pauseMenuUI.SetActive (false);// sets pause menu to inactive
        Time.timeScale = 1f;// resumes time
        GameIsPaused = false; // bool is false
        audio.Play (); // resumes audio
    }

    void Pause () {
        pauseMenuUI.SetActive (true); // sets pause menu to active
        Time.timeScale = 0f; // freezes time
        GameIsPaused = true; /// bool is true
        audio.Pause (); // pauses audio
    }
    public void LoadMenu () {
        Time.timeScale = 1f; // resumes time
        SceneManager.LoadScene (0); // loads scene 0
    }
    public void QuitGame () {
        Debug.Log ("Quitting");
        Application.Quit ();
    }
}