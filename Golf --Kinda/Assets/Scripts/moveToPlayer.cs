using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moveToPlayer : MonoBehaviour
{
    public Transform PlayerPos;
    public int height = 10;

    void Update()
    {
        gameObject.transform.position = PlayerPos.position + new Vector3(0, height, 0);
    }
}
