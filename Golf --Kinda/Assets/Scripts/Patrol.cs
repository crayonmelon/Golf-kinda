using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Patrol : MonoBehaviour
{

    [SerializeField]
    [Range(1, 150)]
    float speed = 40;

    public GameObject[] waypoints;
    int waypointIndex = 0;

    private void Start()
    {
        GetComponent<NavMeshAgent>().speed = speed;

    }
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = waypoints[waypointIndex].transform.position;
        float distanceToWayPoint = Vector3.Distance(gameObject.transform.position, waypoints[waypointIndex].transform.position);
        GetComponent<NavMeshAgent>().isStopped = false;

        if (distanceToWayPoint < 3.0f)
        {
            waypointIndex++;
        }
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
