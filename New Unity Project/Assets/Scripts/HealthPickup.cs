using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    GameManager gameManager;
    public int healthPickup = 1;

        void Awake()
        {
            gameManager = FindObjectOfType<GameManager>();
        }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag.Equals("Player"))
        {
            if(gameManager.P1CurHealth < gameManager.p1LifeMax)
            {
                Destroy(gameObject);
                gameManager.P1CurHealth = gameManager.p1Health + healthPickup;
            }
        }

        if(collider.gameObject.tag.Equals("Player2"))
        {
            if(gameManager.P2CurHealth < gameManager.p2LifeMax)
            {
                Destroy(gameObject);
                gameManager.P2CurHealth = gameManager.p2Health + healthPickup;
            }
        }
    }
            
}

