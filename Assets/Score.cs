using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text playerScore;
    private int scoreNumber;
    void Start(){
        playerScore = GetComponent<Text>();
    }

    void Update(){
        try{
            scoreNumber = player.GetComponent<Player_movement>().score;
        }catch{
            
        }
         
        playerScore.text = "SCORE: " + scoreNumber;




        //varios
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
