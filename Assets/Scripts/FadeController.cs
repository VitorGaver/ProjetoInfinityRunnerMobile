using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    Animator anim;
    SpriteRenderer render;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();

        anim.speed = 0;
    }

    public IEnumerator SetFadeIn()
    {
        anim.speed = 1;
        anim.Play("fadeIn");
        yield return new WaitForSeconds(0.475f);
    }
    public IEnumerator SetFadeOut()
    {
        Debug.Log("teste");
        anim.speed = 1;
        anim.Play("fadeOut");
        yield return new WaitForSeconds(0.475f);
        anim.speed = 0;
    }
}
