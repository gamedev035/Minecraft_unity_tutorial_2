using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : MonoBehaviour
{
    //terrain variables
    public GameObject block;

    public int cols = 16;
    public int rows = 16;
    
    public float freq = 10f;
    public float amp = 10f;

    
    void Update()
    {
        //terrain loop
        for (int x = 0; x < cols; x++)
        {
            for (int z = 0; z < rows; z++)
            {
                float y = Mathf.PerlinNoise(x / freq, z/freq) * amp;

                y = Mathf.Round(y);
                
                for (int h = 0; h < y; h++)
                {
                    Instantiate(block, new Vector3(x, h, z), Quaternion.identity);
                }
            }
        }
    }
}
