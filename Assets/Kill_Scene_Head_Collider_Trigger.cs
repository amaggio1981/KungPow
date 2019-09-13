using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Scene_Head_Collider_Trigger : MonoBehaviour {



    // Use this for initialization
    void Start()
    {

        // add isTrigger
        var boxCollider = GameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {

        void onTriggerEnter(Collider other) {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(1);

            }
        }

