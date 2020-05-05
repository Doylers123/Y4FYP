using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP2 : MonoBehaviour
{
    public static int scoreAmount2;
    public GameObject P2Win;
    public int curScore;
    public Text scoreText2;

    // Start is called before the first frame update
    void Start()
    {

        scoreText2 = GetComponent<Text>();
        scoreAmount2 = 0;
        //curScore = scoreAmount;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText2.text = "P2 Score: " + scoreAmount2;
        curScore = scoreAmount2;

        if (curScore >= 50)
        {
            //SoundManager.PlaySound("Win");
            Time.timeScale = 0f;
            //player2.SetActive(false);
            P2Win.SetActive(true);
        }
    }


}