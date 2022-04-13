using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public bool Moving, Parallax;

    [SerializeField] Vector3 initialPosition, finalPosition;

    public float Speed;
    void Start()
    {
        initialPosition = transform.position;
    }

    
    void Update()
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
        finalPosition = position;
    }
}
