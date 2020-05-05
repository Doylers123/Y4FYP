using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
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
    void Start()
    {
        //countdown = GetComponent<Text>();
        currentTime = startTime;

    }

    

    // Update is called once per frame
    public void Update()
    {
        // deltaTime is the time in seconds it took to complete the last frame
        
        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");
        

        if (currentTime <= 0)
        {
            currentTime = 0;
            winner();
        }
    }//Update

    void winner()
    {

        if (ScoreP2.scoreAmount2 < Score.scoreAmount)
        {
            //SoundManager.PlaySound("Win");
            P1Win.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (ScoreP2.scoreAmount2 > Score.scoreAmount)
        {
            //SoundManager.PlaySound("Win");
            P2Win.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Draw();
        }
    }

    void Draw()
    {
        //SoundManager.PlaySound("Draw");
        DrawGame.SetActive(true);
        Time.timeScale = 0f;
    }

}
