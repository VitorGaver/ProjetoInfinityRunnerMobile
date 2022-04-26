using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rayDistance;
    public float rayCastDistance;
    public float startRayDistance;
    Physics Physics;
    MoveController moveController;

    Vector3 touchPos;
    Touch ActualTouch;

    public bool canMove;

    public LayerMask layerObj;

    /*public LayerMask maskObj;
    public bool canMoveR, canMoveL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Raycast(transform.position, transform.right))
        {
            canMoveR = true;
        }
        if (Physics2D.Raycast(transform.position, Vector2.left))
        {
            canMoveL = true;
        }

        //Direita
        if (Input.GetKeyDown(KeyCode.RightArrow) && Physics2D.Raycast(transform.position, Vector2.right, maskObj))
        {
            transform.Translate(Vector2.right * 1);
        }

        //Esquerda
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Physics2D.Raycast(transform.position, Vector2.left, maskObj))
        {
            transform.Translate(Vector2.left * 1);
        }

        Debug.DrawRay(transform.position, Vector2.right * 1.2f);
        Debug.DrawRay(transform.position, Vector2.left * 1.2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Objeto")
        {
            Debug.Log("Colidiu com objeto");
        }

        if (collision.gameObject.tag == "Parede")
        {
            Debug.Log("Colidiu com a Parede");
        }
    }*/
    void Start()
    {
        moveController = GetComponent<MoveController>();
        Physics = new Physics()
        {
            RayDistance = rayDistance,
            Transform = transform,
            StartRayDistance = startRayDistance,
            RayCastDistance = rayCastDistance,
            LayerObj = layerObj
        };
    }

    private void Update()
    {
        Debug.DrawRay(new Vector2(transform.position.x + startRayDistance, transform.position.y), transform.right * rayCastDistance, Color.red);
        Debug.DrawRay(new Vector2(transform.position.x - startRayDistance, transform.position.y), transform.right * -rayCastDistance, Color.blue);

        #region "PC inputs"
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x >= -0.16f && !moveController.Moving && canMove)
            Physics.Move(false, moveController);
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x <= 0.16f && !moveController.Moving && canMove)
            Physics.Move(true, moveController);
        #endregion

        #region "Android inputs"
        if (Input.touchCount > 0)
        {
            ActualTouch = Input.GetTouch(0);
            if (ActualTouch.phase == TouchPhase.Began) touchPos = ActualTouch.position;
            else if (ActualTouch.phase == TouchPhase.Ended)
            {
                if (ActualTouch.position.x < touchPos.x && transform.position.x >= -0.16f && !moveController.Moving && canMove)
                    Physics.Move(false, moveController);
                else if (ActualTouch.position.x > touchPos.x && transform.position.x <= 0.16f && !moveController.Moving && canMove)
                    Physics.Move(true, moveController);
                Debug.Log(ActualTouch.position.x < ActualTouch.position.x );
            }
        }
        #endregion
    }

}
