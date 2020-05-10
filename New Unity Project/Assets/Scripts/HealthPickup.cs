using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {
    GameManager gameManager;
    public int healthPickup = 1;

    void Awake () {
        gameManager = FindObjectOfType<GameManager> ();
    }

    void OnTriggerEnter2D (Collider2D collider) {
        if (collider.gameObject.tag.Equals ("Player")) { // if collider has the player tag

            if (GameManager.P1CurHealth < gameManager.p1LifeMax) { // if the players current health is less than the players max health
                SoundManager.PlaySound ("Health"); //Plays sound for picking up health item
                Destroy (gameObject); // destroys the health item
                GameManager.P1CurHealth = GameManager.p1Health + healthPickup; //adds the health pick up to the players health
            }
        }

        if (collider.gameObject.tag.Equals ("Player2")) { // if collider has the player tag

            if (GameManager.P2CurHealth < gameManager.p2LifeMax) { // if the players current health is less than the players max health
                SoundManager.PlaySound ("Health"); //Plays sound for picking up health item
                Destroy (gameObject); // destroys the health item
                GameManager.P2CurHealth = gameManager.p2Health + healthPickup; //adds the health pick up to the players health
            }
        }
    }

}