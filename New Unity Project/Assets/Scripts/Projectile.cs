using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Projectile : MonoBehaviour
{

    //public Transform firePoint;
    public float eraserSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        rb.velocity = new Vector2(eraserSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().hurtP1();
        }

        if (other.tag == "Player2")
        {
            FindObjectOfType<GameManager>().hurtP2();
        }
        Destroy(gameObject);
    }
}