using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel_player : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other){
        //revisar suelo
        if (other.gameObject.CompareTag("ground")){
            rb.AddForce(Vector2.up * 6 * 100);
        }
    }
}
