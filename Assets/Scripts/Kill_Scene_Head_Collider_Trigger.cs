﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Scene_Head_Collider_Trigger : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

        // add isTrigger
     //   BoxCollider boxCollider = GetComponent<BoxCollider>();
      //  boxCollider.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {
    }

    void onTriggerEnter(Collider other)
    {
        
        {
            SceneManager.LoadScene(1);

        }
    }
}