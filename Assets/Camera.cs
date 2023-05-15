using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    private bool flagOnce;

    void Start()
    {
        flagOnce = false;
    }


    void Update()
    {
        try {
            transform.position = new Vector3(player.position.x + 10, 15, -10);
        }
        catch (System.Exception){
            if (flagOnce == false){
                flagOnce = true;
                Debug.Log("te moriste wey");
            }
        }
        
    }
}
