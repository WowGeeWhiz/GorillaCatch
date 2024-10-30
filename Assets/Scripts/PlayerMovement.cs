using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 250f;

    // Movement along X and Z axes.
    private float movementX;
    private float movementZ;
    //X and Z speed
    public float speed = 10;
    [SerializeField] float maxSpeed = 10;

    bool isGrounded = true;
    bool canMove = true;
    bool isJumping = false;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        ApplyMovement();
        if (isJumping == false)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }

    public void OnJump()
    {
        if (isGrounded)
        {
            isJumping = true;
            rb.AddForce(transform.up * jumpForce);
        }
    }


    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {
        if (canMove)
        {
            // Convert the input value into a Vector2 for movement.
            Vector2 movementVector = movementValue.Get<Vector2>();

            // Store the X and Y components of the movement.
            movementX = movementVector.x;
            movementZ = movementVector.y;
        }
    }

    void ApplyMovement()
    {
        // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3(movementX, 0.0f, movementZ);
        //Debug.Log(movement * speed);
        // Apply force to the Rigidbody to move the player.
        
        
        rb.AddForce(movement * speed, ForceMode.Force);
        

    }

    public void ToggleCanMove()
    {
        canMove = !canMove;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isGrounded = true;
            isJumping = false;
            //transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isGrounded = false;
            //transform.parent = null;
        }
    }
}
