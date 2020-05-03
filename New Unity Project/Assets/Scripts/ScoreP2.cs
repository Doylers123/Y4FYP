using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreP2 : MonoBehaviour
{
    public static int scoreAmount2;
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

    }


}