using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    Score score;
    void OnTriggerEnter2D(Collider2D col)
    {
        Score.scoreAmount +=1;
        Destroy(gameObject);
    }
}
