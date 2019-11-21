using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayersPosistion : MonoBehaviour
{
    public GameObject[] startingPoints;
    void Start()
    {
        int randomNumer = Random.Range(1, startingPoints.Length);

        gameObject.transform.position = startingPoints[randomNumer].transform.position;
    }
}
