using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
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
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movimento.x);
        animator.SetFloat("Vertical", movimento.y);
        animator.SetFloat("Speed", movimento.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimento * velocita * Time.fixedDeltaTime);
    }
}
