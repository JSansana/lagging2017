using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    
    public GameObject score;
    public AudioSource punch;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
       
        
        if (other.CompareTag("enemy"))
        {
            punch.Play();
            other.GetComponent<Box>().Create_fragments(Random.Range(4,7));
            Destroy(other.gameObject);
            score.GetComponent<Score>().AddScore(5);
        }
    }
}
