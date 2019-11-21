using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlcok : MonoBehaviour
{
    public GameObject end;
    void Start()
    {
        end.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("level1") >= 2)
        {
            end.SetActive(true);

        }
    }
}
