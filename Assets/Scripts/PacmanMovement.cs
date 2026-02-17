using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    
    public int speed = 100;

    Rigidbody2D rb;
    public float maxSpeed = 5f;
    Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        PlayerInput();
    }


    void PlayerInput()
    {
        moveInput = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) moveInput += Vector2.up;
        if (Input.GetKey(KeyCode.S)) moveInput += Vector2.down;
        if (Input.GetKey(KeyCode.A)) moveInput += Vector2.left;
        if (Input.GetKey(KeyCode.D)) moveInput += Vector2.right;
    }

    void FixedUpdate()
    {
        if (moveInput != Vector2.zero)
            rb.velocity = moveInput.normalized * maxSpeed;
        else
            rb.velocity = Vector2.zero;
    }
}
