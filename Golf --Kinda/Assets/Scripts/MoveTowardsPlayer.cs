using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveTowardsPlayer : MonoBehaviour
{
    public GameObject Target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
       Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Target.transform.position;

    }
}
