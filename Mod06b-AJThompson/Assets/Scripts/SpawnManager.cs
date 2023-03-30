using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] animalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    private float startDelay = 2.0f;
    private float spawnInternal = 1.5f;



    void Start()
    {
        InvokeRepeating("SpawnRandomanimal" , startDelay, spawnInternal);
    }

    // Update is called once per frame
    void Update()
    {




    }
           
        

        void SpawnRandomAnimal()
        {

            // Random gen animal index and spawn position 
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    
}
