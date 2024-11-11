using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTopDown : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb2d;
    public Vector2 moveInput;
    public SpriteRenderer spriteRenderer;

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;

        spriteRenderer.flipX = rb2d.velocity.x < 0f;
    }
}
