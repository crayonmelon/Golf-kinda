using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZone : MonoBehaviour
{
    public float windSpeed = 100;
    public GameObject Player;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            print("YOU ARE IN THE WIND ZONE");
            Vector3 wind = gameObject.transform.forward;
            other.gameObject.GetComponent<Rigidbody>().AddForce(wind * windSpeed);
        }
    }

}

