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
    public Text counter;

    [Header ("StartGame")]
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
        StartCoroutine(EnableCanvasUi());
    }

    IEnumerator EnableCanvasUi()
    {
        startBut.SetActive(false);
        counter.gameObject.SetActive(true);
        counter.text = "3";

        yield return new WaitForSeconds(1);

        counter.text = "2";

        yield return new WaitForSeconds(1);

        counter.text = "1";

        yield return new WaitForSeconds(1);

        counter.gameObject.SetActive(false);

        canvasMenu.SetActive(false);

        spawner1.SetActive(true);
        spawner2.SetActive(true);

        playerScript.canMove = true;

        canvasUi.SetActive(true);
    }
}
