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

        vidroText.text = pointsController.pointsQuantity[0].ToString();
        papelText.text = pointsController.pointsQuantity[1].ToString();
        plasticoText.text = pointsController.pointsQuantity[2].ToString();
        metalText.text = pointsController.pointsQuantity[3].ToString();       
    }
}
