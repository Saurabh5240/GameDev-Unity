using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalmovement;
    float verticalmovement;
    public float speed = 15.0F;
    private float xRange = 16;
    private float zRangepos = 15.0F;
    private float zRangeNeg = -0.6F;
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Bounding player in left right movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        //Bounding player in front back movement
        if (transform.position.z < zRangeNeg)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeNeg);

        }
        if (transform.position.z > zRangepos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangepos);

        }


        horizontalmovement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalmovement * Time.deltaTime * speed);

        verticalmovement = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalmovement * Time.deltaTime * speed);
         

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //We will launch the food into prjectile
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z+1.5F), projectilePrefab.transform.rotation);
        }
    }
}
