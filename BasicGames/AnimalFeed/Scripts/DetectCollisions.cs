using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    public bool gameOver;
    public RawImage heart1;
    public RawImage heart2;
    public RawImage heart3;
    private int hitCount = 0;
    public TextMeshProUGUI gameOverText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        hitCount += 1;
        if (hitCount == 1)
        {
            heart1.gameObject.SetActive(false);

        }
        if (hitCount == 2)
        {
            heart2.gameObject.SetActive(false);

        }
        if (hitCount == 3)
        {
            gameOver = true; 
            heart3.gameObject.SetActive(false);
            Destroy(gameObject);
            Debug.Log("Game Over!!!!!!");
            gameOverText.gameObject.SetActive(true);
        }
        
        Destroy(other.gameObject);

    
    }
}
