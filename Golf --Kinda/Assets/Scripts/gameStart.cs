using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public GameObject StartingPoint;

    void Start()
    {
        transform.position = StartingPoint.transform.position;
    }

}
