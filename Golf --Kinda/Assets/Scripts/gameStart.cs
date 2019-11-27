using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    private GameObject StartingPoint;

    void Start()
    {
        StartingPoint = GameObject.FindGameObjectWithTag("PlayerStart");
        transform.position = StartingPoint.transform.position;
    }

}
