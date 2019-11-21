using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSelectManager : MonoBehaviour
{
    public GameObject[] levels;

    void Start()
    {
        for(int i = 0; i < levels.Length; i++)
        {
            levels[i].SetActive(false);

            if (PlayerPrefs.GetInt("LevelsUnlocked") >= i)
            {
                levels[i].SetActive(true);
            }
        }
    }
}
