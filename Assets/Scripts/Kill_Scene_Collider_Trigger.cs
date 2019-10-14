using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Kill_Scene_Collider_Trigger : MonoBehaviour
{

    public ScoreManager theScoreManager;

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
                    Debug.Log("trigger");
                    theScoreManager.scoreIncreasing = true;
                    SceneManager.LoadScene(0);

        }
    }
}