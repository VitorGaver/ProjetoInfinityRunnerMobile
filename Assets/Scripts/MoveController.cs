using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public bool CanMove, Parallax;

    [SerializeField] Vector3 PosicaoInicial, PosicaoFinal;

    public float Speed;
    void Start()
    {
        PosicaoInicial = transform.position;
    }

    
    void Update()
    {
        if (CanMove)
        {
            Move();
        }

        if (transform.position == PosicaoFinal && Parallax)
        {
            transform.position = PosicaoInicial;
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, PosicaoFinal, Speed * Time.deltaTime);
    }
}
