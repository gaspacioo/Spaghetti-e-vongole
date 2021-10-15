using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    Rigidbody2D rb;
    public float velocita = 200;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimentox = Input.GetAxisRaw("Horizontal") * velocita * Time.deltaTime;
        float movimentoy = Input.GetAxisRaw("Vertical") * velocita * Time.deltaTime;

        rb.velocity = new Vector2(movimentox, movimentoy);
    }
}
