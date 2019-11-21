using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCoin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("level1", PlayerPrefs.GetInt("level1") + 1);
            print(PlayerPrefs.GetInt("level1"));

        }
    }
}
