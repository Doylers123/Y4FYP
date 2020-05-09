using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    Score score;
    ScoreP2 score2;
    GameManager gm;
    public GameObject P1Win;
    public GameObject P2Win;
    public GameObject DrawGame;
    public float currentTime;
    public float startTime;

    [SerializeField] Text countdown;

    // Start is called before the first frame update
    void Start () {
        currentTime = startTime;
    }

    // Update is called once per frame
    public void Update () {
        // deltaTime is the time in seconds it took to complete the last frame
        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString ("00");

        if (currentTime <= 0) {
            currentTime = 0;
            winner ();
        }
    } //Update

    void winner () {

        if (ScoreP2.scoreAmount2 < Score.scoreAmount) {
            P1Win.SetActive (true); // reveals the P1Win UI
            Time.timeScale = 0f; // Freezes the game
        } else if (ScoreP2.scoreAmount2 > Score.scoreAmount) {
            //SoundManager.PlaySound("Win");
            P2Win.SetActive (true); // reveals the P2Win UI
            Time.timeScale = 0f; // Freezes the game
        } else {
            Draw (); // runs the draw method
        }
    }

    void Draw () {
        DrawGame.SetActive (true); // reveals the Draw UI
        Time.timeScale = 0f; // Freezes the game
    }

}