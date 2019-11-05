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
            int score = PlayerPrefs.GetInt("LevelScore");

            if (LevelNext < PlayerPrefs.GetInt("LevelsUnlocked"))
            {
                PlayerPrefs.SetInt("LevelsUnlocked", LevelNext);

            }
            print(PlayerPrefs.GetInt("LevelsUnlocked"));
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
