using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasFinalController : MonoBehaviour
{
    [Header("Points")]
    public TextMeshProUGUI papelText;
    public TextMeshProUGUI metalText;
    public TextMeshProUGUI plasticoText;
    public TextMeshProUGUI vidroText;

    [Header("Player")]
    public GameObject player;
    PointsController pointsController;

    private void Start()
    {
        Time.timeScale = 0;

        pointsController = player.GetComponent<PointsController>();

        papelText.text = pointsController.papel.ToString();
        metalText.text = pointsController.metal.ToString();
        plasticoText.text = pointsController.plastico.ToString();
        vidroText.text = pointsController.vidro.ToString();
    }
}
