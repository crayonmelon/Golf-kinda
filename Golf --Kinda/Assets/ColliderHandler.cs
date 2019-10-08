using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public float thrust = 200000f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GolfClub")
        {
       

            Vector3 cam = collision.transform.forward;
            Vector3 camFwd = new Vector3(cam.x, cam.y, cam.z);
            rb.AddForce(camFwd * thrust, ForceMode.Impulse);
        }
    }
}
