using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public int p1Health;
    public int p1LifeMax;
    public int P1CurHealth;
    public int numOfHealth;
    public int p2Health;
    public int p2LifeMax;
    public int P2CurHealth;

    public GameObject P1Win;
    public GameObject P2Win;

    public Image [] p1Lives;
    public Image [] p2Lives;
    public Sprite full;
    public Sprite empty;

    // Start is called before the first frame update
    void Start()
    {
        P1CurHealth = 5;
        P2CurHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {

        p1LifeMax = numOfHealth;
        p1Health = P1CurHealth;

        p2LifeMax = numOfHealth;
        p2Health = P2CurHealth;

        for(int i = 0; i < p1Lives.Length; i++)
        {
            if(p1Health > numOfHealth)
            {
                p1Health = numOfHealth;
            }

            if (i < p1Health)
            {
                p1Lives[i].sprite = full;
            }
            else
            {
                p1Lives[i].sprite = empty;
            }

            if (i < numOfHealth)
            {
                p1Lives[i].enabled = true;
            }
            else
            {
                p1Lives[i].enabled = false;
            }

            if (p1Health <= 0)
            {
                player1.SetActive(false);
                P2Win.SetActive(true);
            }
        }//for

        for(int i = 0; i < p2Lives.Length; i++)
        {
            if(p2Health > numOfHealth)
            {
                p2Health = numOfHealth;
            }

            if (i < p2Health)
            {
                p2Lives[i].sprite = full;
            }
            else
            {
                p2Lives[i].sprite = empty;
            }

            if (i < numOfHealth)
            {
                p2Lives[i].enabled = true;
            }
            else
            {
                p2Lives[i].enabled = false;
            }

            if (p1Health <= 0)
            {
                player1.SetActive(false);
                P2Win.SetActive(true);
                Time.timeScale = 0f;
            }

            if (p2Health <= 0)
            {
                player2.SetActive(false);
                P1Win.SetActive(true);
                Time.timeScale = 0f;
            }
        }// For
    }//Update
    
    public void hurtP1()
    {
        P1CurHealth -= 1;

        for(int i = 0;i < p1Lives.Length; i++)
        {
            if(p1Health > i)
            {
                p1Lives[i].sprite = full;
            }
            else{
                p1Lives[i].sprite = empty;
            }
        }
    }//HurtP1

    public void hurtP2() 
    {
        P2CurHealth -= 1;

        for(int i =0;i < p2Lives.Length; i++)
        {
            if(p2Health > i)
            {
                p2Lives[i].sprite = full;
            }
            else{
                p2Lives[i].sprite = empty;
            }
        }
    }//HurtP2
}
