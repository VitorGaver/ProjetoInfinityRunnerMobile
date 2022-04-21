using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    [Header("Properties")]
    public float rayDistanceY;
    bool canDie = true;

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

        if (Physics2D.Linecast(transform.position, new Vector2(transform.position.x, transform.position.y + rayDistanceY)).collider.tag == "Objeto" && canDie)
        {
            StartCoroutine(died());
            playerLife.lifes--;
            playerLife.checkLifes();
        }
    }

    IEnumerator died()
    {
        canDie = false;

        yield return new WaitForSeconds(1.5f);

        canDie = true;
    }
}
