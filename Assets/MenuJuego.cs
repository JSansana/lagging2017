using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{   

    public string SampleScene;
    public string MenuScene;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RestartGame(){
        Player.GetComponent<Pause>().Resume();
        Player.GetComponent<Pause>().Paused = false;
        SceneManager.LoadScene(SampleScene);

    }

    public void ResumeGame(){
        
        Player.GetComponent<Pause>().Resume();
        Player.GetComponent<Pause>().Paused = false;

    }

    public void LoadMainMenu(){

        Player.GetComponent<Pause>().Resume();
        Player.GetComponent<Pause>().Paused = false;
        SceneManager.LoadScene(MenuScene);

    }
}
