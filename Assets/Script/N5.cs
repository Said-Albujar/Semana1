using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] values = new int[6];
        int acumulador;
        values[0] = 21;
        values[1] = 58;
        values[2] = 10;
        values[3] = 6;
        values[4] = 47;
        values[5] = 29;
        acumulador = 0;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > 0)
            {
                acumulador += values[i];
            }
        }
        Debug.Log(acumulador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
