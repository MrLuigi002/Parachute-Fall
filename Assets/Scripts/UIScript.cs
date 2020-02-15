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

    void Awake() 
    {
        highScore = PlayerPrefs.GetInt("highScore");
        highText.text = "HIGH SCORE: " + highScore;
    }

    void Start()
    {
        InvokeRepeating("AddScore", 1f, 1f);
        
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
