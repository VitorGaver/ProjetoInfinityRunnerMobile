using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
class DeleteObjectsController : MonoBehaviour
{
    MoveController MoveController;

    private void Start()
    {
        MoveController = GetComponent<MoveController>();
    }

    private void Update()
    {
        //if(transform.position == Vector3.zero) GameObject.Find("SpawnerParent").GetComponent<SpawnerController>().Spawn();
        if (transform.position == MoveController.finalPosition) SpawnAndDestroy();
    }

    private void SpawnAndDestroy()
    {
        transform.parent.GetComponent<SpawnerController>().Spawn();
        Destroy(gameObject);
    }
}
