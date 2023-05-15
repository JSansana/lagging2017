using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 8;
    public float jumpSpeed = 7;
    public bool isGrounded;
    public int score;
    private float aux_time;

    public GameObject Hit_Box;


    public GameObject gameOver;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Start(){
        isGrounded = false;
        score = 0;
        aux_time = 0;
    }

    void Update(){
        //Moverse a la derecha
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        //Input para saltar
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(Vector2.up * jumpSpeed * 100);
            isGrounded = false;
        }

        //Input para atacar
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(att());
        }

        //Caerse fuera del nivel
        if ( transform.position.y < 6){
            Debug.Log("te moriste wey");
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        //añadir puntaje cada segundo
        aux_time += Time.deltaTime;
        if (aux_time > 1f)
        {
            score += 1;
            aux_time = 0;
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
            Debug.Log("te moriste wey");
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }

    IEnumerator att()
    {
        Hit_Box.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        Hit_Box.SetActive(false);
    }

}
