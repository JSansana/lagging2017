using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinish : MonoBehaviour
{   

    public string MenuScene;
    public GameObject score;

    private void Awake() {
        score = GameObject.Find("Puntaje");
    }

    public void LoadMainMenu(){
        Destroy(score);
        SceneManager.LoadScene(MenuScene);

    }
}
