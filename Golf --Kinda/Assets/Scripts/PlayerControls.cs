using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody rb;

    public Transform Target;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 cam = Target.forward * -1;
            Vector3 camFwd = new Vector3(cam.x, 0, cam.z);
            rb.AddForce(camFwd * speed);
        }
    }
}
