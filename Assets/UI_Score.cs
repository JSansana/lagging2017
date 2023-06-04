using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Score : MonoBehaviour
{
    public GameObject score;
    private Text score_text;
    private int score_number;

    void Start()
    {
        score_text = GetComponent<Text>();
    }


    void Update()
    {
        score_number = score.GetComponent<Score>().score;

        score_text.text = "SCORE: " + score_number;
    }
}
