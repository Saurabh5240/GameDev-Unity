//Car Game----------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 12.0F;
    private float turnSpeed= 45.0F;
    private float horizontalInput;
    private float forwardInput;
    private float offbounds = 23.5F;
    private float zBound = -10.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // TO bound the player in the given space
        if (transform.position.x > offbounds )
        {
            transform.position = new Vector3(offbounds, transform.position.y, transform.position.z);
        
        }
        if (transform.position.x < -offbounds)
        {
            transform.position = new Vector3(-offbounds, transform.position.y, transform.position.z);

        }
        if (transform.position.z < zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }

            //Get predifined user inputs from unity
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");
        
        
        //We'll move the vehicle forward
        /*float n = 0.05F;
        transform.Translate(0, 0,n);        --- gives a specefic speed but forward has default (0,0,1) value
        */


        //To move vehicle forward
        transform.Translate(Vector3.forward* Time.deltaTime *speed*forwardInput);

        //To rotate the vehile left and right   ---- just to move use translate and vector3.right
        transform.Rotate(Vector3.up,(float)turnSpeed* horizontalInput*Time.deltaTime);
        
    }
}
