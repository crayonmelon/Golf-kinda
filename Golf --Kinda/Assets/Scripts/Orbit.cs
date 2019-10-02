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
    public bool rotateClockwise;

    float timer = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime * rotSpeed;
       

        if (Input.GetKey(KeyCode.A))
        {
            rotSpeed = 5;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rotSpeed = -5;
        }

        else
        {
            rotSpeed = 0;
        }

        Rotate();
        transform.LookAt(centerPoint);
    }

    void Rotate()
    {
        if (rotateClockwise)
        {
            float x = -Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
        else
        {
            float x = Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
    }
}

