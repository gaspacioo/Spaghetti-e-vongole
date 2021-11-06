using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public MovementJoystick movementJoystick;
    public Rigidbody2D rb;
    public float velocita = 5f;
    public Animator animator;

    Vector2 movimento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimento.x = movementJoystick.joystickVec.x;
        movimento.y = movementJoystick.joystickVec.y;

        animator.SetFloat("Horizontal", movimento.x);
        animator.SetFloat("Vertical", movimento.y);
        animator.SetFloat("Speed", movimento.sqrMagnitude);
    }

    void FixedUpdate()
    { 
        if(movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * velocita, movementJoystick.joystickVec.y * velocita);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        //rb.MovePosition(rb.position + movimento * velocita * Time.fixedDeltaTime);
    }
}
