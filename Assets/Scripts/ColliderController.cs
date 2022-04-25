using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    [Header("Properties")]
    public float rayDistanceY;
    public bool canDie = true;
    GameObject colliderGameObj;

    [Header("Scripts")]
    PlayerLife playerLife;
    PointsController pointsController;

    private void Start()
    {
        pointsController = GetComponent<PointsController>();
        playerLife = GetComponent<PlayerLife>();
    }

    private void Update()
    {
        Debug.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y + rayDistanceY), Color.green);

        //if (Physics2D.Linecast(transform.position, new Vector2(transform.position.x, transform.position.y + rayDistanceY)).collider.CompareTag("Objeto") && canDie)
          //StartCoroutine(Died());

        if (Physics2D.Linecast(transform.position, new Vector2(transform.position.x, transform.position.y + rayDistanceY)))
            colliderGameObj = Physics2D.Linecast(transform.position, new Vector2(transform.position.x, transform.position.y + rayDistanceY)).collider.gameObject;

        switch (colliderGameObj.tag)
        {
            case "Objeto":
                if (canDie)
                    StartCoroutine(Died());
                break;
            case "Vidro":
                pointsController.AddQuantity(0);
                break;
            case "Papel":
                pointsController.AddQuantity(1);
                break;
            case "Plastico":
                pointsController.AddQuantity(2);
                break;
            case "Metal":
                pointsController.AddQuantity(3);
                break;
        }

        colliderGameObj = null;
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
