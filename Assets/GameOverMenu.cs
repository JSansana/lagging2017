using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public string SampleScene;
    public string MenuScene;

    public void RestartGame(){

        SceneManager.LoadScene(SampleScene);

    }

    public void LoadMainMenu(){

        SceneManager.LoadScene(MenuScene);

    }
}
