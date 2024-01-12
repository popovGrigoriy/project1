using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
  public float moveSpeed = 5f;

  private Rigidbody2D rb;

  private void Start()
  {
      rb = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
      // Get the input from the arrow keys
      float horizontalInput = Input.GetAxisRaw("Horizontal");
      float verticalInput = Input.GetAxisRaw("Vertical");

      // Calculate the movement vector based on the input
      Vector2 movement = new Vector2(horizontalInput, verticalInput);

      // Move the player using the Rigidbody2D
      rb.velocity = movement * moveSpeed;
  }
}
