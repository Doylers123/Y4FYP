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
        if (collider.gameObject.tag.Equals ("Player")) {

            if (GameManager.P1CurHealth < gameManager.p1LifeMax) {
                SoundManager.PlaySound ("Health");
                Destroy (gameObject);
                GameManager.P1CurHealth = GameManager.p1Health + healthPickup;
            }
        }

        if (collider.gameObject.tag.Equals ("Player2")) {

            if (GameManager.P2CurHealth < gameManager.p2LifeMax) {
                SoundManager.PlaySound ("Health");
                Destroy (gameObject);
                GameManager.P2CurHealth = gameManager.p2Health + healthPickup;
            }
        }
    }

}