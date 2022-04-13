using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics
{
    public float RayDistance;
    public Transform Transform;

    public void Move(bool right, MoveController MoveController)
    {
        if(!CheckHorizontalCollision(right))
        {
            if (right) MoveController.ChangeFinalPosition(new Vector3(Transform.position.x + RayDistance, Transform.position.y, Transform.position.z));
            else if (!right) MoveController.ChangeFinalPosition(new Vector3(Transform.position.x - RayDistance, Transform.position.y, Transform.position.z));

            MoveController.Moving = true;
        }
    }

    bool CheckHorizontalCollision(bool right)
    {
        if(right) return Physics2D.Raycast(Transform.position, new Vector2(Transform.position.x + RayDistance, Transform.position.y));
        else return Physics2D.Raycast(Transform.position, new Vector2(Transform.position.x - RayDistance, Transform.position.y));
    }
}
