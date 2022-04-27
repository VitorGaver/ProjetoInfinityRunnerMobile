using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [Header("Lifes")]
    public int lifes;

    [Header("Game Over")]
    public GameObject mainCamera;
    RestartPhase restartPhase;

    [Header("Life Text Canvas")]
    public GameObject canvasUi;
    CanvasController canvasController;

    private void Start()
    {
        restartPhase = mainCamera.GetComponent<RestartPhase>();
        canvasController = canvasUi.GetComponent<CanvasController>();
    }

    public void CheckLifes()
    {
        canvasController.LifeText.text = lifes.ToString();
        if (lifes == 0) restartPhase.GameOver();
    }
    
    public void AddLifes()
    {
        if (lifes < 3)
        {
            lifes++;
            CheckLifes();
        }
    }
}
