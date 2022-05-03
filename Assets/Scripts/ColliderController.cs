using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    [Header("Properties")]
    public bool canDie = true;

    [Header("Scripts")]
    PlayerLife playerLife;
    PointsController pointsController;

    [SerializeField] CameraController cameraController;

    private void Start()
    {
        pointsController = GetComponent<PointsController>();
        playerLife = GetComponent<PlayerLife>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Objeto") && (canDie))
            StartCoroutine(Died());

        if (trigger.gameObject.CompareTag("Vidro"))
        {
            pointsController.AddQuantity(0);
            Destroy(trigger.gameObject);
        }
            
        if (trigger.gameObject.CompareTag("Papel"))
        {
            pointsController.AddQuantity(1);
            Destroy(trigger.gameObject);
        }
            
        if (trigger.gameObject.CompareTag("Plastico"))
        {
            pointsController.AddQuantity(2);
            Destroy(trigger.gameObject);
        }
            
        if (trigger.gameObject.CompareTag("Metal"))
        {
            pointsController.AddQuantity(3);
            Destroy(trigger.gameObject);
        }

        if (trigger.gameObject.CompareTag("Saco"))
        {
            pointsController.AddTrashBag();
            Destroy(trigger.gameObject);
        }

        if (trigger.gameObject.CompareTag("Life") )
        {
            if (playerLife.lifes < 3) playerLife.AddLifes();
            else pointsController.AddTrashBag();
            Destroy(trigger.gameObject);
        }
            
    }

    IEnumerator Died()
    {
        playerLife.lifes--;
        playerLife.CheckLifes();
        canDie = false;
        if (playerLife.lifes > 0) cameraController.Shake();
        yield return new WaitForSeconds(1.5f);
       
        if(playerLife.lifes > 0) canDie = true;
    }   
}
