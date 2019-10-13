using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndLevel : MonoBehaviour
{
    public int LevelNext;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerPrefs.SetInt("LevelsUnlocked", LevelNext);
            SceneManager.LoadScene("LevelSelect");

            int score = PlayerPrefs.GetInt("LevelScore");
            PlayerPrefs.SetInt("TotalScore", PlayerPrefs.GetInt("TotalScore") + score);
          
            print(PlayerPrefs.GetInt("LevelsUnlocked"));
        }
    }
}
