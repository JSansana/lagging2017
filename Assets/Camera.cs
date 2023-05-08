using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            transform.position = new Vector3(player.position.x + 10, 15, -10);
        }
        catch (System.Exception)
        {

            Debug.Log("te moriste wey");
        }
        
    }
}
