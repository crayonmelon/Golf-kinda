using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayersPosistion : MonoBehaviour
{
    private GameObject[] startingPoints;
    void Start()
    {
        startingPoints = GameObject.FindGameObjectsWithTag("PlayerStart");
        int randomNumer = Random.Range(0, startingPoints.Length);

        gameObject.transform.position = startingPoints[randomNumer].transform.position;
    }
}
