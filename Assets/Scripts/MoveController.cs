using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public bool Moving, Parallax, KeepX, KeepY;

    public Vector3 initialPosition, finalPosition;

    public float Speed;
    void Start()
    {
        if(initialPosition == Vector3.zero)initialPosition = transform.position;
        finalPosition = KeepCoordinades(finalPosition);
    }

    void FixedUpdate()
    {
        if (Moving) Move();
        if (transform.position == finalPosition) 
        {
            if (Parallax) transform.position = initialPosition;
            else Moving = false;
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, finalPosition, Speed * Time.deltaTime);
    }

    public void ChangeFinalPosition(Vector3 position)
    {
        finalPosition = KeepCoordinades(position);
    }

    Vector3 KeepCoordinades(Vector3 position)
    {
        if (KeepX) position.x = initialPosition.x;
        if (KeepY) position.y = initialPosition.y;

        return position;
    }
}
