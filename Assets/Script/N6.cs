using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N6 : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player("Jugador1", 5);
        Player player2 = new Player("Jugador2", 8);

        Debug.Log("Detalles del Jugador 1:");
        Debug.Log("Nombre: " + player1.playerName);
        Debug.Log("Nivel: " + player1.playerLevel);

        Debug.Log("Detalles del Jugador 2:");
        Debug.Log("Nombre: " + player2.playerName);
        Debug.Log("Nivel: " + player2.playerLevel);
    }
    public class Player
    {
        public string playerName;
        public int playerLevel;

        // Constructor de la clase Player
        public Player(string name, int level)
        {
            playerName = name;
            playerLevel = level;
        }
    }

}
