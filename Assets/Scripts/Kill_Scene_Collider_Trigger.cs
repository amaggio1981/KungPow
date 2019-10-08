using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Scene_Collider_Trigger : MonoBehaviour
{

    private ScoreManager theScoreManager;

    // Use this for initialization
    void Start()
    {

        theScoreManager = FindObjectOfType<ScoreManager>();

        // add isTrigger
     //   BoxCollider boxCollider = GetComponent<BoxCollider>();
      //  boxCollider.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        
        {
                    theScoreManager.scoreIncreasing = true;
                    SceneManager.LoadScene(0);

        }
    }
}