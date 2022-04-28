using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
class DeleteObjectsController : MonoBehaviour
{
    MoveController MoveController;
    bool spawner2;

    private void Start()
    {
        MoveController = GetComponent<MoveController>();

        if (transform.parent.GetComponent<SpawnerController>().spawner2) spawner2 = true;
    }

    private void Update()
    {
        //if(transform.position == Vector3.zero) GameObject.Find("SpawnerParent").GetComponent<SpawnerController>().Spawn();
        if (transform.position == MoveController.finalPosition && !spawner2) SpawnAndDestroy();
        else if (transform.position == MoveController.finalPosition && spawner2) Destroy(gameObject);
    }

    private void SpawnAndDestroy()
    {
        transform.parent.GetComponent<SpawnerController>().Spawn();
        transform.parent.GetComponent<SpawnerController>().spawnerController.Spawn();
        Destroy(gameObject);
    }
}
