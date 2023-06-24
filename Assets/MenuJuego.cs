using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{   

    public string SampleScene;
    public string MenuScene;
    public GameObject Player;
    public GameObject Score;
    public GameObject Music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RestartGame(){

        Destroy(Score);
        Player.GetComponent<Pause>().Resume();
        Player.GetComponent<Pause>().Paused = false;
        SceneManager.LoadScene(SampleScene);

    }

    public void ResumeGame(){
        
        Player.GetComponent<Pause>().Resume();
        Player.GetComponent<Pause>().Paused = false;

    }

    public void LoadMainMenu(){

        Destroy(Score);
        Player.GetComponent<Pause>().Resume();
        Music.GetComponent<AudioSource>().Stop();
        Player.GetComponent<Pause>().Paused = false;
        SceneManager.LoadScene(MenuScene);

    }
}
