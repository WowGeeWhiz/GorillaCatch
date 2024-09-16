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

    public bool IsGrounded = true;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(transform.position.y <= -1.5f)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
        }

    }

    public void FixedUpdate()
    {
        ApplyMovement();
    }

    public void OnJump()
    {
        if (IsGrounded)
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }


    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {

        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement.
        movementX = movementVector.x;
        movementZ = movementVector.y;
    }

    void ApplyMovement()
    {
        // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3(movementX, 0.0f, movementZ);
        //Debug.Log(movement * speed);
        // Apply force to the Rigidbody to move the player.
        
        
        if (Vector3.Magnitude(rb.velocity) > 4)// Speed Management
        {
            rb.AddForce(movement * 1, ForceMode.Force);
            Debug.Log(Vector3.Magnitude(rb.velocity));
        }
        else
        {
            rb.AddForce(movement * speed, ForceMode.Force);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            IsGrounded = true;
            transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            IsGrounded = false;
            transform.parent = null;
        }
    }
}
