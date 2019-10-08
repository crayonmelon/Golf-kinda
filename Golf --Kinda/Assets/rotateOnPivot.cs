using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnPivot : MonoBehaviour
{
    public float RotateSpeed = 2f;
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateSpeed, 0, 0);
    }
}
