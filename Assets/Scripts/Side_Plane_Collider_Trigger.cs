﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Side_Plane_Collider_Trigger : MonoBehaviour
{
    // Use this for initialization
    //void Start()
    //{

        // add isTrigger
     //   BoxCollider boxCollider = GetComponent<BoxCollider>();
       // boxCollider.isTrigger = true;

   // }

    // Update is called once per frame
   // void Update()
    //{
    //}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        SceneManager.LoadScene(2);

       
    }
}