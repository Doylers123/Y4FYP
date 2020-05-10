using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour {
    public Transform[] spawnPoints;
    public GameObject[] health;

    int randomSpawnPoint, healthItem;

    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start () {
        spawnAllowed = true;
        //Repeat the spawn in intervals of 20secs after the initial wait of 5 seconds
        InvokeRepeating ("SpawnHealth", 5f, 20f); 
    }

    // Update is called once per frame
    void SpawnHealth () {
        if (spawnAllowed == true) {
            // sets spawn point at random
            randomSpawnPoint = Random.Range (0, spawnPoints.Length); 
            //sets the item to be put in spawn points
            healthItem = Random.Range (0, health.Length); 
            Instantiate (health[healthItem], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity); // initiates the spawns
        }
    }
}