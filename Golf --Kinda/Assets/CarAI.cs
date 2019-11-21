using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarAI : MonoBehaviour
{
    public GameObject target;
    private bool inZone = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inZone == true)
            GetComponent<NavMeshAgent>().destination = target.transform.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        inZone = true;
    }
}
