using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public bool cigsCollected;
    public GameObject CigsCollect;


    private void Start()
    {
        CigsCollect.SetActive(false);
    }
    void Update()
    {
        if(cigsCollected == true)
        {
            CigsCollect.SetActive(true);
        }
        else
        {
            CigsCollect.SetActive(false);
        }
    }
}
