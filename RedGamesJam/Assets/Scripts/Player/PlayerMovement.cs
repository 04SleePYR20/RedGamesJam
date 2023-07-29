using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 2f;

    [SerializeField]
    float rotationSpeed = 16f;

    [SerializeField]
    Joystick joystick;


    Rigidbody2D rb;

    Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirection = new Vector2(joystick.Horizontal, joystick.Vertical);
    }

    private void FixedUpdate()
    {
        SetVelocity();
        RotateInDirectionOfInput();
    }

    private void SetVelocity()
    {
        rb.velocity = movementDirection * movementSpeed;
    }

    private void RotateInDirectionOfInput()
    {
        if (movementDirection != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, movementDirection);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            rb.MoveRotation(rotation);
        }
    }
}
