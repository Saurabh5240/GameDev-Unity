using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public DetectCollisions playervars;

    public GameObject[] animalPrefabs;
    public GameObject[] animalFromLeft;
    public GameObject[] animalFromRight;
    //Variables for spawn position 1
    private float spawnPosX = 20.0F;
    private float spawnPosZ = 20.0F;
    //Time Variables for Spawn Interval
    private float spawnStart = 2.0F;
    private float spawnInterval = 2.0F;

    //Variables for spawn posotion 2
    private float spawnposX2 = -20.0F;

    //Variables for spawn position 3
    private float spawnposX3 = 18.0F;
    


    // Start is called before the first frame update
    void Start()
    {
        playervars = GameObject.Find("Player").GetComponent<DetectCollisions>();
        
        InvokeRepeating("SpawnRandomAnimal", spawnStart, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        if (!playervars.gameOver)
        {
            int indexAnimal = Random.Range(0, animalPrefabs.Length);

            Vector3 spawnPos1 = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
            Instantiate(animalPrefabs[indexAnimal], spawnPos1, animalPrefabs[indexAnimal].transform.rotation);

            Vector3 spawnPos2 = new Vector3(spawnposX2, 0, Random.Range(2, 14));
            Instantiate(animalFromLeft[indexAnimal], spawnPos2, animalFromLeft[indexAnimal].transform.rotation);

            Vector3 spawnPos3 = new Vector3(spawnposX3, 0, Random.Range(2, 14));
            Instantiate(animalFromRight[indexAnimal], spawnPos3, animalFromRight[indexAnimal].transform.rotation);

        }
        



    }


}
