using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWorld : MonoBehaviour
{
    public float RotateSpeed = 2f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateSpeed, 0);
    }
}
