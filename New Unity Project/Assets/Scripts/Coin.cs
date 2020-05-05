using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.gameObject.tag.Equals("Player"))
        {
            SoundManager.PlaySound("Coin");
            Score.scoreAmount +=1;
            Destroy(gameObject);
        }

        if(col.gameObject.tag.Equals("Player2"))
        {
            SoundManager.PlaySound("Coin");
            ScoreP2.scoreAmount2 +=1;
            Destroy(gameObject);
        }
    }
}
