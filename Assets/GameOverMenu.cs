using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public string SampleScene;
    public string MenuScene;
    public GameObject score;

    public void RestartGame(){
        Destroy(score);
        SceneManager.LoadScene(SampleScene);

    }

    public void LoadMainMenu(){

        Destroy(score);
        SceneManager.LoadScene(MenuScene);

    }
}
