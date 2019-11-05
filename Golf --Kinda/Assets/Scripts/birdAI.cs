using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdAI : MonoBehaviour
{
    [SerializeField]
    [Range(0.1f, 1)]
    float speed;
    bool PatrolTime = true;
    bool dropped = true;

    public GameObject player;
    public GameObject[] waypoints;
    int waypointIndex = 0;
   
    void Update()
    {
        if(PatrolTime == true)
        {
            Patrol();

        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PatrolTime = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (dropped == true && other.tag =="Player") {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PatrolTime = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" && dropped == true)
        {
            PatrolTime = true;
            dropped = false;

            player.transform.parent = gameObject.transform;
            player.transform.Translate(0, 0, 0);
            player.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, gameObject.transform.position + new Vector3(0, 10, 0), speed);
            Invoke("DropPlayer", 5f);
        }
    }

   public void Patrol()
    {
        transform.LookAt(waypoints[waypointIndex].transform.position);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, waypoints[waypointIndex].transform.position, speed);
        float distanceToWayPoint = Vector3.Distance(gameObject.transform.position, waypoints[waypointIndex].transform.position);
        if (distanceToWayPoint < 3.0f)
        {
            waypointIndex++;
        }
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

    void DropPlayer()
    {
        print("Drop");
        player.transform.parent = null;
        player.GetComponent<Rigidbody>().isKinematic = false;
        Invoke("ResetBird", 5f);
    }

    void ResetBird()
    {
        dropped = true;
    }
}
