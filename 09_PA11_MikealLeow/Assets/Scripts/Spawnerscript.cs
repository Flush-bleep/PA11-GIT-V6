using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    float PositionY;

    public GameObject[] Cubes;

    private float CurrentSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentSpawn = Random.Range(0, 3);
    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        if (CurrentSpawn == 0)
        {
            Instantiate(Cubes[0], transform.position, transform.rotation);
        }

        if (CurrentSpawn == 1)
        {
            Instantiate(Cubes[1], transform.position, transform.rotation);
        }

        if (CurrentSpawn == 2)
        {
            Instantiate(Cubes[2], transform.position, transform.rotation);
        }

    }
}
