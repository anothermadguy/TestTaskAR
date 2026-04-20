using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPodium : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnpoint;

    private List<GameObject> spawnedObjects = new List<GameObject>();

    private void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        var temp = Instantiate(prefab, spawnpoint.position, Quaternion.identity);
        spawnedObjects.Add(temp);
    }

    public void DestroyAllSpawnedObjects()
    {
        foreach (var spawnedObject in spawnedObjects)
        {
            Destroy(spawnedObject);
        }
        spawnedObjects.Clear();
    }
}
