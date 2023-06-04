using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    private void Start() {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void AddScore(int points){
        score += points;
    }

}
