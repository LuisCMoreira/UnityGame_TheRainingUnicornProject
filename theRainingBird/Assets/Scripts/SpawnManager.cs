using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public GameObject[] foodPrefabs;
    private float spawnRangeX=17.0f;
    private float spawnPosZ=235;
    private float startDelay = 0;
    private float spawnInterval = 2;
    private Vector3 offsetUp = new Vector3(0,2.25f,0);

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
            int platformIndex1 =Random.Range(0, platformPrefabs.Length);
            int platformIndex2 =Random.Range(0, platformPrefabs.Length);
             int foodIndex1 =Random.Range(0, foodPrefabs.Length);
             int foodIndex2 =Random.Range(0, foodPrefabs.Length);

            Vector3 spawnPos1 = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),spawnPosZ,-110);
            Vector3 spawnPos2 = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),spawnPosZ + Random.Range(-1,1),-110);

            if(spawnPos1.x > 0)
            {
            
            spawnPos2 = new Vector3(Random.Range(-spawnRangeX,0),spawnPosZ,-110);
            }
            else
            {
 
            spawnPos2 = new Vector3(Random.Range(0,spawnRangeX),spawnPosZ,-110);   
            }


            Instantiate(platformPrefabs[platformIndex1], spawnPos1, platformPrefabs[platformIndex1].transform.rotation);
            Instantiate(foodPrefabs[foodIndex1], spawnPos1+offsetUp, foodPrefabs[foodIndex1].transform.rotation);


            Instantiate(platformPrefabs[platformIndex2], spawnPos2, platformPrefabs[platformIndex2].transform.rotation);
            Instantiate(foodPrefabs[foodIndex2], spawnPos2+offsetUp, foodPrefabs[foodIndex2].transform.rotation);
    }
}
