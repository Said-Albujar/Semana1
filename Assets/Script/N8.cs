using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class N8 : MonoBehaviour
{
    public class Forma
    {
        public virtual void Dibujar()
        {
            Debug.Log("Dibujando una forma gen�rica.");
        }
    }

    public class Circulo : Forma
    {
        public override void Dibujar()
        {
            Debug.Log("Dibujando un c�rculo.");
        }
    }

    public class Rectangulo : Forma
    {
        public override void Dibujar()
        {
            Debug.Log("Dibujando un rect�ngulo.");
        }
    }
    void Start()
    {
        Forma forma1 = new Circulo();
        Forma forma2 = new Rectangulo();

        forma1.Dibujar(); 
        forma2.Dibujar(); 
    }
}
