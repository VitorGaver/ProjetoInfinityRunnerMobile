using System.Collections;
using UnityEngine;

public class ChangeSpriteController : MonoBehaviour
{
    [SerializeField] Sprite[] SpriteList;
    SpriteRenderer SpriteRenderer;
    // Use this for initialization
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        ChangeBackground();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBackground()
    {
        int i = Random.Range(0, SpriteList.Length);
        SpriteRenderer.sprite = SpriteList[i];
    }
}