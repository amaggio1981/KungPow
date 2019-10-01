using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Counter : MonoBehaviour {

    float currentTime = 0f;
    float startingTime = 0F;
    public Text counterText;

    // Use this for initialization
    void Start () {

        currentTime = startingTime;    
 
		
	}
		// Update is called once per frame
	void Update () {
        currentTime += 1 * Time.deltaTime;
        print(currentTime);
        counterText.text = currentTime.ToString("0");

		
	}
}
