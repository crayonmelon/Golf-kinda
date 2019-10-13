using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public GameObject Player;
    public float speed = 10f; 

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, Player.transform.position, speed);
            gameObject.transform.LookAt(Player.transform.position);

        }
    }

}
