using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public int score = 0;
    public int highScore = 0;
    public Text scoreText;
    public Text highText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddScore", 0f, 1f);
        highScore = PlayerPrefs.GetInt("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore()
    {
        score++;      

        if(score > highScore)
        {
            PlayerPrefs.SetInt("highScore", score);
        }

        scoreText.text = "SCORE: " + score;
        highText.text = "HIGH SCORE: " + highScore;
    }
}
