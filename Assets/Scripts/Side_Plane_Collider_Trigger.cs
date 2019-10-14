using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Side_Plane_Collider_Trigger : MonoBehaviour
{


    private ScoreManager theScoreManager;

    void Start()
    {

        theScoreManager = FindObjectOfType<ScoreManager>();

        
    }

    void OnTriggerEnter(Collider other)
    {

        theScoreManager.scoreIncreasing = false;
        Debug.Log("Trigger");
        SceneManager.LoadScene(2);

       
    }
}