using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    ColliderController colliderControllerl;
    Animator animator;

    private void Start()
    {
        colliderControllerl = GetComponent<ColliderController>();
        animator = GetComponent<Animator>();

        animator.SetBool("Death", false);
    }
    private void Update()
    {
        if (colliderControllerl.canDie == false)
        {
            animator.SetBool("Death", true);
        }
        else if (colliderControllerl.canDie == true)
            animator.SetBool("Death", false);
    }
}
