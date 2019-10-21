using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Top_Plane_Collider_Trigger : MonoBehaviour
{

    public Score_Manager theScoreManager;



    // Use this for initialization
    void Start()
    {

        theScoreManager = FindObjectOfType<Score_Manager>();

       

        // add isTrigger
        //   BoxCollider boxCollider = GetComponent<BoxCollider>();
        // boxCollider.isTrigger = true;

        // }

        // Update is called once per frame
        // void Update()
        //{
    }

    void OnTriggerEnter(Collider other)
    {
      
        theScoreManager.scoreIncreasing = false;
        Debug.Log("Trigger");
        Debug.Log(theScoreManager.scoreCount);
        SceneManager.LoadScene(1);



       
    }
}