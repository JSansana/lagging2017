using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndLevel_score : MonoBehaviour
{
    public GameObject score;
    private int score_number;
    private TMP_Text score_text;

    private void Awake() {
        try{
            score = GameObject.Find("Puntaje");
        }catch{
            Debug.Log("no se encontro");
        }
        
    }

    void Start()
    {
        score_number = score.GetComponent<Score>().score;
        score_text = GetComponent<TMP_Text>();

        score_text.text = "You had a score of: " + score_number + " pts.";

    }
    
}
