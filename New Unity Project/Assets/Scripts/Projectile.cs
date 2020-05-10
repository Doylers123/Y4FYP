using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Projectile : MonoBehaviour {

    //public Transform firePoint;
    public float eraserSpeed;
    private Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D> (); // gets the rigidbody for the projectile
    }

    void Update () {
        rb.velocity = new Vector2 (eraserSpeed * transform.localScale.x, 0); // moves the projectile at a set speed along the x-axis
    }

    void OnTriggerEnter2D (Collider2D other) { //on trigger enter
        if (other.tag == "Player") { // if the triggers tag is named Player
            FindObjectOfType<GameManager> ().hurtP1 (); // finds and runs the method in GameManager script.
        }

        if (other.tag == "Player2") { // if the triggers tag is named Player
            FindObjectOfType<GameManager> ().hurtP2 (); // finds and runs the method in GameManager script.
        }
        Destroy (gameObject); // destroys the projectile after it hits the trigger.
    }
}