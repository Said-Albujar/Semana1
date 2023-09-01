using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = 10;

        if (a > 0)
        {
            Debug.Log("Positivo");
        }

        else if (a < 0)
        {
            Debug.Log("Negativo");
        }

        else if (a == 0)
        {
            Debug.Log("Es cero");
        }

        else
        {
            Debug.Log("Valor desconocido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
