using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasMenuController : MonoBehaviour
{
    [Header ("Canvas")]
    public GameObject canvasMenu;
    public GameObject canvasUi;
    public GameObject startBut;

    [Header("StartGame")]
    public GameObject Player;
    PlayerMovement playerScript;
    public GameObject spawner1, spawner2;


    public void Start()
    {
        playerScript = Player.GetComponent<PlayerMovement>();

        Time.timeScale = 0;
    }
    public void StartGame()
    {
        Time.timeScale = 1;

        startBut.SetActive(false);

        StartCoroutine(EnableCanvasUi());
    }

    IEnumerator EnableCanvasUi()
    {
        yield return new WaitForSeconds(3);

        canvasMenu.SetActive(false);

        spawner1.SetActive(true);
        spawner2.SetActive(true);

        playerScript.canMove = true;

        canvasUi.SetActive(true);
    }
}
