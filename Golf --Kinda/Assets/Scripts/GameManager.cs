using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager instance;


    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        PlayerPrefs.SetInt("LevelsUnlocked", 0);
        PlayerPrefs.SetInt("TotalScore", 0);
        PlayerPrefs.SetInt("LevelScore", 0);
    }

    #endregion

    public GameObject player;

}


