using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moveToPlayer : MonoBehaviour
{
    public Transform PlayerPos;

    void Update()
    {
        gameObject.transform.position = PlayerPos.position + new Vector3(0,10,0);
    }
}
