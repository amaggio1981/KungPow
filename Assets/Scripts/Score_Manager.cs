using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;
    public Text lastScoreText;

    public float scoreCount;
    public float hiScoreCount;
    public float lastScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;
    // bool is true false

    // Use this for initialization
    void Start()
    {
        hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        


    }

    // Update is called once per frame
    void Update()
    {

       lastScoreCount = PlayerPrefs.GetFloat("LastScore");

        if  (scoreIncreasing)
        // this is a bool- will only trigger if scoreIncreasing = True
        {
            scoreCount += pointsPerSecond + Time.deltaTime;
            PlayerPrefs.SetFloat("LastScore", scoreCount);

            // Time.delta is the time it took to do the last frame
        }
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
            // PlayerPrefs is a saving system that takes a string and a float input

        }
        
        

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        //Mathf is a math function library in unity
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);
        //lastScoreText.text = "Last Score: " + Mathf.Round(lastScoreCount);
        lastScoreText.text = "Last Score: " + Mathf.Round(lastScoreCount);



    }
}
