using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public LayerMask maskObj;
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
    }
}
