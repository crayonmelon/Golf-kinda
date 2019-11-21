using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FrogAI : MonoBehaviour
{
    public float thrust = 15;
    Animator anim;
    AnimatorStateInfo info;
    Ray ray;
    RaycastHit hit;
    public float thickness = 10f;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        ray.origin = gameObject.transform.position;
        ray.direction = gameObject.transform.forward;
        
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.green);
        info = anim.GetCurrentAnimatorStateInfo(0);

        GameObject target = GameObject.Find("Player");
        float distanceBetweenNPCAndPlayer = Vector3.Distance(gameObject.transform.position, target.transform.position);


        if (Physics.SphereCast(ray.origin, thickness, ray.direction * 100, out hit))
        {
            if(hit.collider.gameObject.name == "Player")
            {
                anim.SetBool("Crawl", true);
                print("I see you");
            }

            if (distanceBetweenNPCAndPlayer < 3f)
            {
                anim.SetBool("Attack", true);
            }

        }

        if (info.IsName("Idle"))
        {
            GetComponent<NavMeshAgent>().isStopped = true;

        }

        if (info.IsName("Crawl"))
        {
            GetComponent<NavMeshAgent>().destination = target.transform.position;
            GetComponent<NavMeshAgent>().isStopped = false;

        }

        if (distanceBetweenNPCAndPlayer > 3f) anim.SetBool("Attack", false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust, ForceMode.Impulse);
            
        }

        if(collision.gameObject.tag == "FrogArea")
        {
            PlayerPrefs.SetInt("level1", PlayerPrefs.GetInt("level1") + 1);
            Destroy(gameObject);
        }
    }


}
