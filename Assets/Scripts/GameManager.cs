using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("ScenesSpawn")]
    public GameObject[] Scenes;
    public int selectedScene;
    int lastScene;

    [Header("PlayerSpawn")]
    public GameObject Player;
    public GameObject spawnPlayerPos;

    void Start()
    {
        Instantiate(Scenes[0], new Vector3(0, 0, 0), Quaternion.identity);
        lastScene = 0;
        SpawnScene(new Vector3(0, 10, 0));
        Instantiate(Player, spawnPlayerPos.transform.position, Quaternion.identity);
    }
    
    public void SpawnScene(Vector3 spawnPos)
    {
        while (selectedScene == lastScene)
        {
            selectedScene = Random.Range(0, 3);
        }
            Instantiate(Scenes[selectedScene], spawnPos, Quaternion.identity);
            lastScene = selectedScene;
    }
}
