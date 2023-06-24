using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeman_behaviour : MonoBehaviour
{
    public float policeman_speed = 8;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Dada cierta distancia con el jugador, policeman empezara a moverse
        if ((transform.position - player.transform.position).x <= 17)  {
            //Moverse a la izquierda
            transform.Translate(Vector2.left * policeman_speed * Time.deltaTime);
        }
            
        
    }
}
