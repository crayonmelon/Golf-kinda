using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateMissionMessage : MonoBehaviour
{
    TextMeshProUGUI TextPro;
    public string LevelName = "level1";

    // Start is called before the first frame update
    void Start()
    {
        TextPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TextPro.text = "Missions Complete: " + PlayerPrefs.GetInt(LevelName) + "/2";
    }
}
