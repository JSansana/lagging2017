using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float jumpForce = 5f; // The force of the circle's jump
    public float moveSpeed = 3f; // The speed at which the circle moves
    private Rigidbody2D rb; // The circle's rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Personaje moviendose hacia la derecha automáticamente
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (rb.velocity.y == 0){
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }


    }
}
