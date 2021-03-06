using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPhase : MonoBehaviour
{
    bool canRestart = true;
    [Header("Canvas")]
    public GameObject canvasFinal;
    public GameObject canvasUI;
    public GameObject canvasMenu;

    public void RestartGame()
    {
        SceneManager.LoadScene(0);        
    }

    /*IEnumerator Restart()
    {
        canRestart = false;
        yield return StartCoroutine(fade.SetFadeIn());
        SceneManager.LoadScene(0);
    }*/

    public void GameOver()
    {
        canvasFinal.SetActive(true);
        canvasUI.SetActive(false);
        canvasMenu.SetActive(false);
    }
}
