using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefab;
    private Vector3 spawnPos = new Vector3(20, 0, 0);
    private float startDelay = 2.0F;
    private float repeatInterval = 2.0F;
    private PlayerController playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        int indexObstacle = Random.Range(0, objectPrefab.Length);
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(objectPrefab[indexObstacle], spawnPos, objectPrefab[indexObstacle].transform.rotation);

        }


    }
}
