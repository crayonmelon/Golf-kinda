using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageFrogs : MonoBehaviour
{

    public GameObject[] frogs;
    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            frogs[i].SetActive(false);
        }
        int dif = PlayerPrefs.GetInt("Difficulty");

        if(dif == 2)
        {
            frogs[0].SetActive(true);
            frogs[1].SetActive(true);
            frogs[2].SetActive(true);
            frogs[3].SetActive(true);

        }
        else if(dif ==1)
        {
            frogs[1].SetActive(true);
            frogs[0].SetActive(true);

        }
        else
        {
            frogs[0].SetActive(true);

        }
    }
}
