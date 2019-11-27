using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class OJControls : MonoBehaviour
{
    private GameObject[] waypoints;
    private GameObject Target;
    public float MaxSpeed = 20;

    public AudioClip HeyTWitterWorld;
    public AudioClip GettingEven;
    private AudioSource audioS;

    public Camera cam;

    bool SeeYou;
    NavMeshAgent agent;
    int waypointIndex = 0;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
        agent = GetComponent<NavMeshAgent>();
        waypoints = GameObject.FindGameObjectsWithTag("OJWaypoint");
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
 
        if (SeeYou)
            ISeeYou();
        else
            Patrol();
    }

    void Patrol()
    {
        agent.destination = waypoints[waypointIndex].transform.position;
        float distanceToWayPoint = Vector3.Distance(gameObject.transform.position, waypoints[waypointIndex].transform.position);
        agent.isStopped = false;

        if (distanceToWayPoint < 3.0f)
        {
            waypointIndex++;
        }
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

    void ISeeYou()
    {
        agent.destination = Target.transform.position;
        agent.speed = MaxSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        SeeYou = true;
        audioS.PlayOneShot(HeyTWitterWorld, 1f);

    }

    private void OnCollisionEnter(Collision collision)
    {
        audioS.PlayOneShot(GettingEven, 1f);
        StartCoroutine(ResetLevel());
      //  Time.timeScale = 0f;

    }

    IEnumerator ResetLevel()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("LevelMaze");
    }
}
