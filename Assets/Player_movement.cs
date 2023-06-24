using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 8;
    public float maxSpeed = 15;
    public float jumpSpeed = 7;
    public bool isGrounded;
    private float aux_time;
    public bool canAttack = true;
    public bool activeAttack = false;
    private Quaternion initialRotation;

    public GameObject Hit_Box;
    public GameObject gameOver;
    public GameObject GameOverMenu;
    public GameObject score;
    public GameObject Music;


    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
        initialRotation = transform.rotation;
    }

    void Start(){
        isGrounded = false;
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
        if (Input.GetKeyDown(KeyCode.F) && canAttack)
        {
            StartCoroutine(att());
        }

        //Caerse fuera del nivel
        if ( transform.position.y < 6){
            Debug.Log("te moriste wey");
            Music.GetComponent<AudioSource>().Stop();
            gameOver.SetActive(true);
            GameOverMenu.SetActive(true);
            Destroy(gameObject);
        }

        //añadir puntaje cada segundo
        aux_time += Time.deltaTime;
        if (aux_time > 1f)
        {
            score.GetComponent<Score>().AddScore(1);
            aux_time = 0;
        }

        //rotacion de jugador respecto a superficies
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f);

        if (hit.collider != null)
        {
            Vector2 surfaceNormal = hit.normal;

            float angle = Vector2.Angle(transform.up, surfaceNormal);

            if (angle <= 45 && isGrounded)
            {
                Quaternion targetRotation = Quaternion.FromToRotation(transform.up, surfaceNormal) * transform.rotation;
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
            }
        }

        if(!isGrounded)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, initialRotation, 10f * Time.deltaTime);
        }

        //velocidad de jugador
        if (moveSpeed < maxSpeed)
        {
            moveSpeed += 0.5f * Time.deltaTime;
        }

        if (moveSpeed > maxSpeed)
        {
            moveSpeed = maxSpeed;
        }
        
    
        //varios
        //Reiniciar el nivel
        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void OnCollisionEnter2D(Collision2D other){
        //revisar suelo
        if (other.gameObject.CompareTag("ground")){
            if(isGrounded == false){
                isGrounded = true;
            }
        }

        //morir al chocar contra enemigo/caja
        if ((other.gameObject.CompareTag("enemy")) || (other.gameObject.CompareTag("crate"))|| (other.gameObject.CompareTag("police")))
        {
            Debug.Log("te moriste wey");
            Music.GetComponent<AudioSource>().Stop();
            gameOver.SetActive(true);
            GameOverMenu.SetActive(true);
            Destroy(gameObject);
        }
    }
    
    private void OnCollisionExit2D(Collision2D other){
        //Cuando ya no se esta en el suelo
        if (other.gameObject.CompareTag("ground")){
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //Cuando llega a la meta
        if (other.gameObject.CompareTag("LevelExit")){
            SceneManager.LoadScene("Finish_Level");
        }
    }

    IEnumerator att()
    {
        Hit_Box.SetActive(true);
        activeAttack = true;
        canAttack = false;
        yield return new WaitForSeconds(0.3f);
        Hit_Box.SetActive(false);
        activeAttack = false;
        canAttack = true;
    }

}
