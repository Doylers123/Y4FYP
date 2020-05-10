using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode eraser;

    public Rigidbody2D rb;

    public Transform groundCheck;
    public Transform throwPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public bool isGrounded;
    public GameObject projectile;

    void Start () {
        rb = GetComponent<Rigidbody2D> (); // gets the players rigidbody
    }

    void Update () {
        // checks for what is set as the ground in the level
        isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround); 

        if (Input.GetKey (left)) { // if the key set for moving left is hit
            rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y); // moves the player left at set movement speed
        } else if (Input.GetKey (right)) { // if the key set for moving right is hit
            rb.velocity = new Vector2 (moveSpeed, rb.velocity.y); // moves the player right at set movement speed
        } else {
            rb.velocity = new Vector2 (0, rb.velocity.y); // if no key is pressed the player will not move
        }

        if (Input.GetKeyDown (jump) && isGrounded) { // if the player is on the ground and the jump key is pressed
            SoundManager.PlaySound ("Jump"); // plays the jump sound clip from sound manager script
            rb.velocity = new Vector2 (rb.velocity.x, jumpForce); // player moves up with a set jump force
        }

        if (Input.GetKeyDown (eraser)) { // if the key is pressed to shoot
            SoundManager.PlaySound ("Gun"); //plays the Gun sound clip from sound manager script
            // shoots the projectile from a set shooting point on the player
            GameObject eraserClone = (GameObject) Instantiate (projectile, throwPoint.position, throwPoint.rotation); 
            eraserClone.transform.localScale = transform.localScale;
        }

        if (rb.velocity.x < 0) {
            transform.localScale = new Vector3 (-1, 1, 1); // sets the scale of the projectile when shooting left
        } else if (rb.velocity.x > 0) {
            transform.localScale = new Vector3 (1, 1, 1); // sets the scale of the projectile when shooting right
        }

    }

}