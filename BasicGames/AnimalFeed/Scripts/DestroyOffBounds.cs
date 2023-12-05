using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffBounds : MonoBehaviour
{
    private float topBounds = 30.0F;
    private float lowerBound = -10.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);

        }
        else if (transform.position.z < lowerBound)
        {
            
            Destroy(gameObject);
        
        }
        else if (transform.position.x < -22.0F)
        {

            Destroy(gameObject);

        }
        else if (transform.position.x > 20)
        {

            Destroy(gameObject);

        }

    }
}
