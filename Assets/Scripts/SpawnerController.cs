using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject[] ItemList;
    public bool spawner1;
    public bool spawner2;

    public GameObject spawner2Obj;
    [HideInInspector] public SpawnerController spawnerController;

    void Start()
    {
        Spawn();
        if (spawner1) spawnerController = spawner2Obj.GetComponent<SpawnerController>();
    }

    public void Spawn()
    {
        int i = Random.Range(0, ItemList.Length);
        Instantiate(ItemList[i], transform);
    }
    
    
}
