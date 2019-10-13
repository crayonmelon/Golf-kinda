using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody rb;
    public float maxSpeed = 50f;

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
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 cam = Target.forward;
            Vector3 camFwd = new Vector3(cam.x, 0, cam.z);
            rb.AddForce(camFwd * speed);
        }

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

    }
}
