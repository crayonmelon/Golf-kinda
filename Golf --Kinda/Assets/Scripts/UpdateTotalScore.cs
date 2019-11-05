using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateTotalScore : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        text.text = "Total Score: " + PlayerPrefs.GetInt("TotalScore");

    }
}
