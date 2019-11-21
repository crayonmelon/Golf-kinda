using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int MissionsComplete;
    public string LevelName = "level1";
    float time;
    float cycle = 5.0f;
    int currentLevel;

    void Start()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
        PlayerPrefs.SetInt(LevelName, 0);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > cycle)
        {
            currentLevel = PlayerPrefs.GetInt("Difficulty");
            currentLevel++;
            if (currentLevel > 2) currentLevel = 2;
            time = 0;
        }
    }

    public void MissionCompleted()
    {
        MissionsComplete++;
        PlayerPrefs.SetInt(LevelName, MissionsComplete);

    }
}
