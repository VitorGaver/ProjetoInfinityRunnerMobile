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
    
    MoveController MoveController;
    ChangeSpriteController ChangeSprite;
 
    private void Start()
    {
        
        MoveController = GetComponent<MoveController>();
        ChangeSprite = GetComponent<ChangeSpriteController>();
    }

    private void Update()
    {
        if (transform.position == MoveController.initialPosition && MoveController.Moving) ChangeSprite.ChangeBackground();
    }

    
}
