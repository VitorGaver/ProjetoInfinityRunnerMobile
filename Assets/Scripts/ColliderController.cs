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
            pointsController.AddQuantity(0);
        if (trigger.gameObject.CompareTag("Papel"))
            pointsController.AddQuantity(1);
        if (trigger.gameObject.CompareTag("Plastico"))
            pointsController.AddQuantity(2);
        if (trigger.gameObject.CompareTag("Metal"))
            pointsController.AddQuantity(3);
    }

    IEnumerator Died()
    {
        playerLife.lifes--;
        playerLife.checkLifes();
        canDie = false;

        yield return new WaitForSeconds(1.5f);
       
        canDie = true;
    }   
}
