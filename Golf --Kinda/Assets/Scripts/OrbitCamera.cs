using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public float xSpread = 10;
    public float zSpread = 10;
    public float yOffset = 10;
    public float scrollSpeed = 2f;
    public Transform centerPoint;

    float rotSpeed;
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = .1f;
    public float smoothSpeed = 0.25f;
    float timer = 0;


    void FixedUpdate()
    {

        rotSpeed = horizontalSpeed * Input.GetAxis("Mouse X");

        // if (Input.GetAxis("Mouse Y") > 0){
        //      yOffset = yOffset + verticalSpeed;
        //  }
        //   else if (Input.GetAxis("Mouse Y") < 0)
        //   {
        //       yOffset = yOffset - verticalSpeed;
        //   }
       // xSpread = Mathf.Clamp(10f, 1, 30);
       // zSpread = Mathf.Clamp(10f, 1, 30);
       // yOffset = Mathf.Clamp(10f, 1, 30);

        Rotate();
        transform.LookAt(centerPoint);
        timer += Time.deltaTime * rotSpeed;

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            xSpread = xSpread + scrollSpeed;
            zSpread = zSpread + scrollSpeed;
            yOffset = yOffset + scrollSpeed;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            xSpread = xSpread - scrollSpeed;
            zSpread = zSpread - scrollSpeed;
            yOffset = yOffset - scrollSpeed;
        }
    }

    void Rotate()
    {
        float x = -Mathf.Cos(timer) * xSpread;
        float z = Mathf.Sin(timer) * zSpread;
        Vector3 pos = new Vector3(x, yOffset, z);
        Vector3 desiredPosition =  pos + centerPoint.position;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }
}
