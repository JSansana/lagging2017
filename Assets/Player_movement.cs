using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 8;
    public float jumpSpeed = 7;
    public bool isGrounded;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Start(){
        isGrounded = false;
    }

    void Update(){
        //Moverse a la derecha
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(Vector2.up * jumpSpeed * 100);
            isGrounded = false;
        }

        //Caerse fuera del nivel
        if( transform.position.y < 6){
            Destroy(gameObject);
            Debug.Log("te moriste wey");
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        //revisar suelo
        if (other.gameObject.CompareTag("ground")){
            if(isGrounded == false){
                isGrounded = true;
            }
        }

        //morir al chocar contra enemigo
        if (other.gameObject.CompareTag("enemy")){
            Destroy(gameObject);
        }
    }

}
