using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spookCamera : MonoBehaviour
{
    private float xSpread = 4;
    private float zSpread = 4;
    private float yOffset = 1;

    // public Toggle OneHandedCameraToggle;
    //public Toggle InvertToggle;
    public Transform centerPoint;
    private Transform Pointer;

    float rotSpeed;
    float timer = 0;

    [Header("Camera Speeds")]
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = .1f;
    public float smoothSpeed = 0.25f;
    public float scrollSpeed = 2f;

    private float countDown = 2;

    [Header("Camera Attributes for Options")]

    public bool CameraReset = false;
    public bool OneHandedMode = false;
    public bool InvertScroll = false;
    int scrollInverter = 1;

    private void Start()
    {
        Pointer = centerPoint.GetChild(0);
    }

    void FixedUpdate()
    {


        /*
        if (OneHandedCameraToggle.isOn)
        {
            OneHandedMode = true;
        }
        else
        {
            OneHandedMode = false;
        }

        if (InvertToggle.isOn)
        {
            InvertScroll = true;
        }
        else
        {
            InvertScroll = false;
        }
        */

        countDown -= 1 * Time.deltaTime;
        print(countDown);

        if (OneHandedMode == true)
        {
            oneHandMode();
        }
        else
        {
            RotateNormal();

        }

        if (InvertScroll == true)
        {
            scrollInverter = -1;
        }
        else
        {
            scrollInverter = 1;
        }


        if (Input.GetAxis("Mouse ScrollWheel") * scrollInverter > 0)
        {
            xSpread = Mathf.Clamp(xSpread + scrollSpeed, 4, 10);
            zSpread = Mathf.Clamp(zSpread + scrollSpeed, 4, 10);
            yOffset = Mathf.Clamp(yOffset + scrollSpeed, 1, 6);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") * scrollInverter < 0)
        {
            xSpread = Mathf.Clamp(xSpread - scrollSpeed, 4, 10);
            zSpread = Mathf.Clamp(zSpread - scrollSpeed, 4, 10);
            yOffset = Mathf.Clamp(yOffset - scrollSpeed, 1, 6);
        }
    }

    void RotateNormal()
    {
        transform.LookAt(centerPoint);
        if (Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse X") < 0)
        {
            timer += Time.deltaTime * rotSpeed;


            rotSpeed = horizontalSpeed * Input.GetAxis("Mouse X");
        }
        else if (countDown <= 0 && CameraReset == true)
        {

            timer = Pointer.GetComponent<Orbit>().timer;
            countDown = 2;
        }

        float x = Mathf.Cos(timer) * xSpread;
        float z = -Mathf.Sin(timer) * zSpread;
        Vector3 pos = new Vector3(x, yOffset, z);
        Vector3 desiredPosition = pos + centerPoint.position;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    void oneHandMode()
    {
        timer = Mathf.Lerp(timer, Pointer.GetComponent<Orbit>().timer * -1, smoothSpeed);
        transform.LookAt(centerPoint);
        float x = -Mathf.Cos(timer) * xSpread;
        float z = Mathf.Sin(timer) * zSpread;
        Vector3 pos = new Vector3(-x, yOffset, z);
        Vector3 desiredPosition = pos + centerPoint.position;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
