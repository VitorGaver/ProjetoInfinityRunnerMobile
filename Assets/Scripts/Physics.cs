using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics
{
    public float RayDistance;
    public float RayCastDistance;
    public float StartRayDistance;
    public Transform Transform;
    public LayerMask LayerObj;

    public void Move(bool right, MoveController MoveController)
    {
        if (!CheckHorizontalCollision(right))
        {
            if (right) MoveController.ChangeFinalPosition(new Vector3(Transform.position.x + RayDistance, Transform.position.y, Transform.position.z));
            else if (!right) MoveController.ChangeFinalPosition(new Vector3(Transform.position.x - RayDistance, Transform.position.y, Transform.position.z));

            MoveController.Moving = true;
        }
        else Debug.Log($"estou coledindo com o lado direito: {right}");
    }

    bool CheckHorizontalCollision(bool right)
    {
        if (right)            
            return Physics2D.Raycast(new Vector2(Transform.position.x + StartRayDistance, Transform.position.y), Transform.right * RayCastDistance, LayerObj);
        else return Physics2D.Raycast(new Vector2(Transform.position.x - StartRayDistance, Transform.position.y), Transform.right * -RayCastDistance, LayerObj);
    }
}
