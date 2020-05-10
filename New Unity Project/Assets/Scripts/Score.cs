using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    GameManager gameManager;
    public GameObject P1Win;
    public static int scoreAmount;
    public int curScore;

    public Text scoreText;

    Countdown cd;
    // Start is called before the first frame update
    void Start () {
        scoreAmount = 0; //Sets starting score to 0
        scoreText = GetComponent<Text> (); // gets the text component
    }

    // Update is called once per frame
    void Update () {

        scoreText.text = "P1 Score: " + scoreAmount; // adds the score to the score text
        curScore = scoreAmount;

        if (curScore >= 50) { // if score reaches 0
            Time.timeScale = 0f; // freezes time
            P1Win.SetActive (true); //Player one win screen appears

        }

    }

}