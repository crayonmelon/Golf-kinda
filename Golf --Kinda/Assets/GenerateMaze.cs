using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMaze : MonoBehaviour
{
    public GameObject wall;
    public int[,] worldMap = new int[,]
    {
        {1, 1, 1, 1, 1, 1, 0, 1, 1, 1},
        {1, 0, 0, 1, 1, 1, 0, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 1, 1, 1, 0, 1, 1, 1, 0, 1},
        {1, 1, 1, 1, 0, 1, 1, 0, 0, 1},
        {1, 1, 1, 1, 0, 1, 1, 1, 0, 1},
        {1, 1, 1, 1, 0, 1, 1, 1, 0, 1},
        {1, 1, 1, 0, 0, 0, 0, 0, 0, 1},
        {1, 1, 1, 0, 0, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}

    };
    void Start()
    {
       int i, j;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                GameObject t;
                if (worldMap[i, j] == 1)
                {
                    t = (GameObject)(Instantiate(wall, new Vector3(50.0f - i * 10.0f, 1.5f, 50 - j * 10), Quaternion.identity));
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
