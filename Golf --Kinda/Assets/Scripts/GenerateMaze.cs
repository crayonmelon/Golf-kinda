using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMaze : MonoBehaviour
{
    Color[,] colorOfPixel;
    public Texture2D OutlineImage;
    public GameObject wall;
    public GameObject start;
    public GameObject enemy;
    public GameObject OJWaypoint;
    public GameObject EndLevel;
    public TextAsset[] textFile;
    public int MapSize = 4;
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
    void Awake()
    {
        //MapSize += 1;
        GenerateFromFile();
      
    }


    void GenerateFromArray()
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

   void GenerateFromFile()
    {
        int randomNumer = Random.Range(0, textFile.Length);

        print(randomNumer);
        string s = textFile[0].text;
        print(s);
        int i;
        int column, row;
        print("Size of map: " + s.Length);
        s = s.Replace("\n", "");
        print("Size of map: "+ s.Length);
        print(s);
        for (i=0; i < s.Length; i++)
        {
            if(s[i]=='1')
            {
               
                column = i % MapSize;
                row = i / MapSize;
                GameObject t = (GameObject)(Instantiate(wall, new Vector3(50 - column * 10.0f, 1.5f, 50 - row * 10.0f), Quaternion.identity));

            }
            if(s[i] == 'S')
            {
                column = i % MapSize;
                row = i / MapSize;
                GameObject t = (GameObject)(Instantiate(start, new Vector3(50 - column * 10.0f, 1.5f, 50 - row * 10.0f), Quaternion.identity));
            }
            if(s[i] == 'J')
            {
                column = i % MapSize;
                row = i / MapSize;
                GameObject t = (GameObject)(Instantiate(enemy, new Vector3(50 - column * 10.0f, 1.5f, 50 - row * 10.0f), Quaternion.identity));
            }
            if(s[i] == 'W')
            {
                column = i % MapSize;
                row = i / MapSize;
                GameObject t = (GameObject)(Instantiate(OJWaypoint, new Vector3(50 - column * 10.0f, 1.5f, 50 - row * 10.0f), Quaternion.identity));
            }

            if (s[i] == 'E')
            {
                column = i % MapSize;
                row = i / MapSize;
                GameObject t = (GameObject)(Instantiate(EndLevel, new Vector3(50 - column * 10.0f, 1.5f, 50 - row * 10.0f), Quaternion.identity));
            }
        }
    }

    void GenerateFromImage()
    {
        colorOfPixel = new Color[OutlineImage.width, OutlineImage.height];
        for(int x = 0; x< OutlineImage.width; x++)
        {
            for(int y = 0; y < OutlineImage.height; y++)
            {
                colorOfPixel[x, y] = OutlineImage.GetPixel(x, y);
                if (colorOfPixel[x, y] != Color.white)
                {
                    GameObject t = (GameObject)(Instantiate(wall, new Vector3(OutlineImage.width / 2 * 10 - x * 10f, 1.5f, (OutlineImage.height / 2) * 10 - y * 10), Quaternion.identity));
                }
            }
        }
    }
}
