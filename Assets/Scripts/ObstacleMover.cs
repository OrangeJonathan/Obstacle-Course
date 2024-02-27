using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;
    private bool isMovingToB = true; // Flag to track direction

    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(pointA.position, pointB.position);
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        
        if (isMovingToB)
        {
            transform.position = Vector3.Lerp(pointA.position, pointB.position, fracJourney);
        }
        else
        {
            transform.position = Vector3.Lerp(pointB.position, pointA.position, fracJourney);
        }
        
        if (fracJourney >= 1.0f)
        {
            startTime = Time.time;
            isMovingToB = !isMovingToB; // Change direction
        }
    }
}
