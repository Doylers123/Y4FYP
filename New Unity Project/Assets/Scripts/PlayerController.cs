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
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update () {
        isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey (left)) {
            rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y);
        } else if (Input.GetKey (right)) {
            rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
        } else {
            rb.velocity = new Vector2 (0, rb.velocity.y);
        }

        if (Input.GetKeyDown (jump) && isGrounded) {
            SoundManager.PlaySound ("Jump");
            rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown (eraser)) {
            SoundManager.PlaySound ("Gun");
            GameObject eraserClone = (GameObject) Instantiate (projectile, throwPoint.position, throwPoint.rotation);
            eraserClone.transform.localScale = transform.localScale;
        }

        if (rb.velocity.x < 0) {
            transform.localScale = new Vector3 (-1, 1, 1);
        } else if (rb.velocity.x > 0) {
            transform.localScale = new Vector3 (1, 1, 1);
        }

    }

}