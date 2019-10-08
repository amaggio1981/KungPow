using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;
    // bool is true false

       	// Use this for initialization
	void Start () {
        if(PlayerPrefs.GetFloat("HighScore") != null)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
	}
	
	// Update is called once per frame
	void Update () {
        
        if
            (scoreIncreasing)
            // this is a bool- will only trigger if scoreIncreasing = True
        { 
        scoreCount += pointsPerSecond + Time.deltaTime;
            // Time.delta is the time it took to do the last frame
        }
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
            // PlayerPrefs is a saving system that takes a string and a float input
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        //Mathf is a math function library in unity
        hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount);

	
        
	}
}
