using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static N7.Personaje;

public class N7 : MonoBehaviour
{
    public class Personaje
    {
        public class Jugador : Personaje
        {
            public int nivel;

            public Jugador(string nombre, int salud, int nivel) : base(nombre, salud)
            {
                this.nivel = nivel;
            }
        }

        public string nombre;
        public int salud;

        public Personaje(string nombre, int salud)
        {
            this.nombre = nombre;
            this.salud = salud;
        }

        public void MostrarInfo()
        {
            Debug.Log("Nombre: " + nombre + ", Salud: " + salud);
        }
    }

    void Start()
    {
        Jugador jugador1 = new Jugador("Jugador1", 100, 5);

        Debug.Log("Detalles del Jugador 1:");
        jugador1.MostrarInfo();


        Debug.Log("Nivel del Jugador 1: " + jugador1.nivel);
    }

}
