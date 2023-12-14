using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 20.0F;
    private float fastSpeed = 1.8F;
    private PlayerController playerControllerScript;
    private float leftBound = -10.0F;
    public bool isFast = false;
    public int score = 0;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

            if (Input.GetKeyDown(KeyCode.LeftShift))       //I have used the GetKeyUp and GetKeyDown to move the screen fast when shift is at hold.....
            {
                isFast = true;


            }
            if (isFast)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed * fastSpeed);

            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                isFast = false;


            }

        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            
            Destroy(gameObject);
            
        
        }

        

    }
}
