using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class updateScore : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + PlayerPrefs.GetInt("LevelScore");
    }
}
