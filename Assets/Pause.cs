using UnityEngine;
using System.Collections;
 
public class Pause : MonoBehaviour {
     
    public GameObject MenuJuego;
    public GameObject Player;
    public bool Paused = false;
 
    void Start(){
        MenuJuego.gameObject.SetActive (false);
    }
 
    void Update () {
        if (Input.GetKeyDown("escape")) {
            if(Paused == true){
                Time.timeScale = 1.0f;
                MenuJuego.gameObject.SetActive (false);
                Paused = false;
                if (Player.GetComponent<Player_movement>().activeAttack == false){
                    Player.GetComponent<Player_movement>().canAttack = true;
                }
            } else {
                Time.timeScale = 0.0f;
                MenuJuego.gameObject.SetActive (true);
                Paused = true;
                if (Player.GetComponent<Player_movement>().activeAttack == false){
                    Player.GetComponent<Player_movement>().canAttack = false;
                }
            }
        }
    }
    public void Resume(){
        Time.timeScale = 1.0f;
        MenuJuego.gameObject.SetActive (false);
        if (Player.GetComponent<Player_movement>().activeAttack == false){
                Player.GetComponent<Player_movement>().canAttack = true;
        }

     }
}  