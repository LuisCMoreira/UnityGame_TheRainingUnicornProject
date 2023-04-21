using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFood : MonoBehaviour
{
    public GameObject[] foodPrefabs;
        private float spawnRangeX=17.0f;
    private float spawnPosZ=235;
    private float startDelay = 0;
    private float spawnInterval = 2;

  // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPlatform", startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomPlatform()
    {

            int foodIndex1 =Random.Range(0, foodPrefabs.Length);
            Vector3 spawnPos1 = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),spawnPosZ,-110);



            Instantiate(foodPrefabs[foodIndex1], spawnPos1, foodPrefabs[foodIndex1].transform.rotation);

    }
}
