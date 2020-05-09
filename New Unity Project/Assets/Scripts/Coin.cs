using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D col) {
        // if the game objects tag is equal to player
        if (col.gameObject.tag.Equals ("Player")) {
            SoundManager.PlaySound ("Coin"); // plays sound for coin
            Score.scoreAmount += 1; // one coin adds one to score
            Destroy (gameObject); // Destroys the coin
        }

        // if the game objects tag is equal to player
        if (col.gameObject.tag.Equals ("Player2")) {
            SoundManager.PlaySound ("Coin"); // plays sound for coin
            ScoreP2.scoreAmount2 += 1; // one coin adds one to score
            Destroy (gameObject); // Destroys the coin
        }
    }
}