using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAndCollect : MonoBehaviour
{
    public int RotateX = 1, RotateY = 1, RotateZ = 1;
    public GameObject canvas;
    void Update()
    {
        transform.Rotate(RotateX, RotateY, RotateZ);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.GetComponent<Collectables>().cigsCollected = true;
            Destroy(gameObject);
        }
    }
}
