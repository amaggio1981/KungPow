﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreTemplate : MonoBehaviour {

    private Transform entryContainer;
    private Transform entryTemplate;
	

	private void Awake () {
        entryContainer = transform.Find("highscoreEntryContainer");
        Debug.Log(entryContainer);
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");
        Debug.Log(entryTemplate);
        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 20f;
            for (int i = 0; i < 10; i++) {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);
        }
        // hides template entry
    }
}
