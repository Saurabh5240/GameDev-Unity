using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    





    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;
        scoreText.text = "Score: " + score;
        
        
    }
   

    public void UpdateScore(int addScore)
    {
        
        score += addScore;
        scoreText.text = "Score: " + score;
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
