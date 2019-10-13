using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSelectManager : MonoBehaviour
{
    public GameObject Level0Button;
    public GameObject Level1Button;
    public GameObject Level2Button;

    void Start()
    {
        Level0Button.SetActive(false);
        Level1Button.SetActive(false);
        Level2Button.SetActive(false);

        if (PlayerPrefs.GetInt("LevelsUnlocked") >= 2)
        {
            Level2Button.SetActive(true);
        }
        if (PlayerPrefs.GetInt("LevelsUnlocked") >= 1)
        {
            Level1Button.SetActive(true);
        }
        if (PlayerPrefs.GetInt("LevelsUnlocked") >= 0)
        {
            Level0Button.SetActive(true);
        }
    }
}
