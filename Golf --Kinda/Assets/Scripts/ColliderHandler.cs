using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public float thrust = 15f;
    private Rigidbody rb;
    public GameObject StartingPoint;
    public float windSpeed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Bounderies")
        {

            transform.position = StartingPoint.transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

        }
        if (collision.gameObject.tag == "GolfClub")
        {


                Vector3 cam = collision.transform.forward;
                Vector3 camFwd = new Vector3(cam.x, cam.y, cam.z);
                rb.AddForce(camFwd * thrust, ForceMode.Impulse);
        }

        if (collision.gameObject.tag == "GolfClub2")
        {
            print("its a hit");

            Vector3 cam = collision.transform.forward *-1;
            Vector3 camFwd = new Vector3(cam.x, cam.y, cam.z);
            rb.AddForce(camFwd * thrust, ForceMode.Impulse);
        }



    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "GolfClub")
        {

            Vector3 cam = collision.transform.forward;
            Vector3 camFwd = new Vector3(cam.x, cam.y, cam.z);
            rb.AddForce(camFwd * thrust, ForceMode.Impulse);
        }

        if (collision.gameObject.tag == "GolfClub2")
        {
            print("its a hit");

            Vector3 cam = collision.transform.forward * -1;
            Vector3 camFwd = new Vector3(cam.x, cam.y, cam.z);
            rb.AddForce(camFwd * thrust, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("LevelScore", PlayerPrefs.GetInt("LevelScore") + 1);
            print(PlayerPrefs.GetInt("LevelScore"));
        }
    }

}