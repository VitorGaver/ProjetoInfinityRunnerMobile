using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject[] ItemList;

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        int i = Random.Range(0, ItemList.Length);
        Instantiate(ItemList[i], transform);
    }
    
    
}
