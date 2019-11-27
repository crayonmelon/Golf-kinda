using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float xSpread;
    public float zSpread;
    public float yOffset;
    public Transform centerPoint;

    public float rotSpeed;

    public float timer = 0;

    void FixedUpdate()
    {

        Rotate();
        transform.LookAt(centerPoint);
        timer += Time.deltaTime * rotSpeed;

    //Controls left and right
        if (Input.GetKey(KeyCode.A))
            rotSpeed = -5;
        else if (Input.GetKey(KeyCode.D))
            rotSpeed = 5;
        else
            rotSpeed = 0;

    }

    void Rotate()
    {
            float x = -Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
    }
}

