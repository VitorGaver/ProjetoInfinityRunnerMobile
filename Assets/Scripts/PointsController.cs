using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour
{
    [Header("Canvas")]
    public Image pointsL;
    public Image pointsR;
    public Text pointsText;
    public Sprite[] pointsSprites;

    [Header("Pontos")]
    public int[] pointsQuantity; //0 = vidro, 1 = papel, 2 = plastico, 3 = metal
    public int lastPoint;

    public void ChangeSpriteCanvas(int ponto)
    {
        pointsText.text = pointsQuantity[ponto].ToString();
        pointsL.sprite = pointsSprites[ponto];
        pointsR.sprite = pointsSprites[ponto];
    }

    public void AddQuantity(int ponto)
    {
        pointsQuantity[ponto]++;

        ChangeSpriteCanvas(ponto);

        lastPoint = ponto;
    }

    public void AddTrashBag()
    {
        pointsQuantity[0]++;
        pointsQuantity[1]++;
        pointsQuantity[2]++;
        pointsQuantity[3]++;

        ChangeSpriteCanvas(lastPoint);
    }
}
