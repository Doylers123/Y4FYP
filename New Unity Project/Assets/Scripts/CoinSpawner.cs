using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Transform[] coinSpawnPoints;
    public GameObject[] coin;

    int coinRandomSpawnPoint, coinItem;

    public static bool coinSpawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        coinSpawnAllowed = true;
        InvokeRepeating ("SpawnCoin", 5f, 5f);
    }

    // Update is called once per frame
    void SpawnCoin()
    {
        if(coinSpawnAllowed == true)
        {
            coinRandomSpawnPoint = Random.Range (0, coinSpawnPoints.Length);
            coinItem = Random.Range (0, coin.Length);
            Instantiate (coin[coinItem], coinSpawnPoints [coinRandomSpawnPoint].position, 
            Quaternion.identity);
        }
    }
}