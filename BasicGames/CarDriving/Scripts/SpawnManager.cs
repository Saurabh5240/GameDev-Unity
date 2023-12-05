using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carobstacle;

    private float spawnStart = 2.0F;
    private float spawnInterval = 1.5F;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomVehicles", spawnStart, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        

    }
    void spawnRandomVehicles()
    {
        int obstacleIndex = Random.Range(0, carobstacle.Length);

        Vector3 range = new Vector3(Random.Range(-22,32),1,165);
        Instantiate(carobstacle[obstacleIndex], range, carobstacle[obstacleIndex].transform.rotation);

        

    }
}
