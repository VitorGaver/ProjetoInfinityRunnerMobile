using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasController : MonoBehaviour
{
    [Header("Pontuação")]
    public Image PointsL;
    public Image PointsR;
    public TextMeshProUGUI PointsText;

    [Header("Vidas")]
    public TextMeshProUGUI LifeText;

    [Header("Config")]
    public GameObject ConfigPanel;

    public void Start()
    {
        Config();
    }

    public void Config()
    {
        ConfigPanel.SetActive(!ConfigPanel.activeSelf);

        if (ConfigPanel.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
