using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public Transform[] patrolPoints;
    private int currentPoint;

    void Start()
    {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
    }

    void Update()
    {
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;

            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;
            }
        }
        transform.position = Vector3.MoveTowards
                (transform.position, patrolPoints[currentPoint].position,
                Time.deltaTime * moveSpeed);
    }
}
