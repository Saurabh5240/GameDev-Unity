using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    
    public float rotationSpeed=30.0F;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
