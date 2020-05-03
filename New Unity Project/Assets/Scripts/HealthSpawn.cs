using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] health;

    int randomSpawnPoint, healthItem;

    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating ("SpawnHealth", 5f, 20f);
    }

    // Update is called once per frame
    void SpawnHealth()
    {
        if(spawnAllowed == true)
        {
            randomSpawnPoint = Random.Range (0, spawnPoints.Length);
            healthItem = Random.Range (0, health.Length);
            Instantiate (health[healthItem], spawnPoints [randomSpawnPoint].position, 
            Quaternion.identity);
        }
    }
}