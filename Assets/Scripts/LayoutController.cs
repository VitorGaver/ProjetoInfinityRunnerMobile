using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutController : MonoBehaviour
{
    /*public float moveSceneSpeed;

    private GameObject gameManagerObj;
    private GameManager gameManager;

    Vector3 final = new Vector3(0, -10, 0);

    // Start is called before the first frame update
    void Start()
    {
        gameManagerObj = GameObject.Find("GameManager");
        gameManager = gameManagerObj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 1 * moveSceneSpeed * Time.deltaTime);

        if (transform.position.y <= final.y)
        {
            gameManager.SpawnScene(new Vector3(0, transform.position.y + 20));
            Destroy(gameObject);
        }
    }*/
    [SerializeField] Sprite[] BackgroundsList;
    SpriteRenderer SpriteRenderer;
    MoveController MoveController;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        MoveController = GetComponent<MoveController>();

        ChangeBackground();
    }

    private void Update()
    {
        if (transform.position == MoveController.initialPosition && MoveController.Moving) ChangeBackground();
    }

    void ChangeBackground()
    {
        int i = Random.Range(0, BackgroundsList.Length);
        SpriteRenderer.sprite = BackgroundsList[i];
    }
}
