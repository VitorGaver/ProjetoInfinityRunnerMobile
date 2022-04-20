﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
class DeleteObjects : MonoBehaviour
{
    MoveController MoveController;

    private void Start()
    {
        MoveController = GetComponent<MoveController>();
    }

    private void Update()
    {
        if (transform.position == MoveController.finalPosition) SpawnAndDestroy();
    }

    private void SpawnAndDestroy()
    {
        GameObject.Find("").GetComponent<SpawnerController>().Spawn();
        Destroy(gameObject);
    }
}