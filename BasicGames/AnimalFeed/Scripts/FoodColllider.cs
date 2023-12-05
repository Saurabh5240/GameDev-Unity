using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodColllider : MonoBehaviour
{
    private int score = 1;
    private GameManager gameManager;
   
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("SpawnManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter(Collider other)
    {

        other.gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
        Destroy(gameObject);
        
        
    }
}
