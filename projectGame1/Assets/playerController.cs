using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float flapForce = 100f;
    public float forwardSpeed = 2f;
    private GameObject bird;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bird = GameObject.Find("bird");
    }

    void Update()
    {
        // Flap the bird when the player presses the space key or taps the screen
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * flapForce);
        }

        // Move the bird forward continuously
        rb.velocity = new Vector2(forwardSpeed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // End the game if the bird collides with anything
        Debug.Log("Game Over!");
        // Get the parent game object
        Destroy(bird);
    }
}
