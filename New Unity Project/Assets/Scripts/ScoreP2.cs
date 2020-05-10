using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP2 : MonoBehaviour {
    public static int scoreAmount2;
    public GameObject P2Win;
    public int curScore;
    public Text scoreText2;

    // Start is called before the first frame update
    void Start () {

        scoreText2 = GetComponent<Text> (); // Gets the text component
        scoreAmount2 = 0; // sets starting score to 0
    }

    // Update is called once per frame
    void Update () {
        scoreText2.text = "P2 Score: " + scoreAmount2; // adds the score to the score text
        curScore = scoreAmount2;

        if (curScore >= 50) { // if score reaches 0
            Time.timeScale = 0f; // freeze time
            P2Win.SetActive (true); // player 2 win screen appears
        }
    }

}