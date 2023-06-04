using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float patrolDistance = 5f; 
    public float speed = 2f;

    private Vector3 startPos;
    private Vector3 leftTargetPos;
    private Vector3 rightTargetPos;
    private bool movingRight = true;

    private void Start()
    {
        startPos = transform.position;
        leftTargetPos = startPos - Vector3.right * patrolDistance;
        rightTargetPos = startPos + Vector3.right * patrolDistance;
    }

    private void Update()
    {
        // Determine the target position based on the direction of movement
        Vector3 targetPos = movingRight ? rightTargetPos : leftTargetPos;

        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // Check if the square has reached the target position
        if (transform.position == targetPos)
        {
            // Change the direction of movement
            movingRight = !movingRight;
        }
    }
}
