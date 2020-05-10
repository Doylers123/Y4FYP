using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {
    public Transform[] coinSpawnPoints;
    public GameObject[] coin;

    int coinRandomSpawnPoint, coinItem;

    public static bool coinSpawnAllowed;

    // Start is called before the first frame update
    void Start () {
        coinSpawnAllowed = true; // coin spawn is on
        //Repeat the spawn in intervals of 1 second after the initial wait of 5 seconds
        InvokeRepeating ("SpawnCoin", 5f, 1f); 
    }

    // SpawnCoin
    void SpawnCoin () {
        // if coin spawn is on
        if (coinSpawnAllowed == true) {
            coinRandomSpawnPoint = Random.Range (0, coinSpawnPoints.Length); // sets spawn point at random
            coinItem = Random.Range (0, coin.Length); //sets the item to be put in spawn points
            Instantiate (coin[coinItem], coinSpawnPoints[coinRandomSpawnPoint].position,
                Quaternion.identity); // initiates the spawns
        }
    }
}