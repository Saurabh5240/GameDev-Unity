using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCars : MonoBehaviour
{
    public float speed = 13.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime*speed);
    }
}
