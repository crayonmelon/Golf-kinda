using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class difficultySet : MonoBehaviour
{
    public TMP_Dropdown m_Dropdown;

    public void ChangeDifficulty()
    {
        if (m_Dropdown.value == 0)
        {
            PlayerPrefs.SetInt("Difficulty", 0);
        }
        else if (m_Dropdown.value == 1)
        {
            PlayerPrefs.SetInt("Difficulty", 1);

        }
        else if (m_Dropdown.value == 2)
        {
            PlayerPrefs.SetInt("Difficulty", 2);

        }
    }
}
