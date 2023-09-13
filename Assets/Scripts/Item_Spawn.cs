using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnObject;
    [SerializeField]
    Transform spawnSpot;

    private void Start()
    {
        var itm = Instantiate(spawnObject[Random.Range(0, spawnObject.Length)],
            spawnSpot.transform.position, Quaternion.identity);

        // This will "connect/parent" the child's position to the parent one
        itm.transform.parent = gameObject.transform;
    }
}
