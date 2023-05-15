using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    public float amplitude = 0.1f;
    public float speed = 2f;

    private void Update()
    {
        Vector3 p = transform.position;
        p.y = p.y + amplitude * Mathf.Cos(Time.time * speed);
        transform.position = p;
    }
}
