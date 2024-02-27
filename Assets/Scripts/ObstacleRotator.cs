using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public enum Direction
{
    X,
    Y,
    Z
}

public class ObstacleRotator : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0;
    [SerializeField] Direction direction = Direction.X;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = 1 * Time.deltaTime * moveSpeed;
        switch (direction)
        {
            case Direction.X:
                transform.Rotate(angle, 0, 0);
                break;
            case Direction.Y:
                transform.Rotate(0, angle, 0);
                break;
            case Direction.Z:
                transform.Rotate(0, 0, angle);
                break;
        }
    }

}
