﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class updateScore : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
         text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + PlayerPrefs.GetInt("LevelScore");
    }
}