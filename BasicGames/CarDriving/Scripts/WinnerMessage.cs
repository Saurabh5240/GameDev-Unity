using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Car"))
        {
            Debug.Log("Car player won!!!");



        }
        else if(collider.gameObject.CompareTag("Tank"))
        {
            Debug.Log("Tank Player won!!!");
        
        }
            
        
        
    
    }
}
