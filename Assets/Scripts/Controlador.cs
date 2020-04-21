using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controlador : MonoBehaviour
{
    public Sprite cruz, circulo;
    public GameObject casilla;

    public GameObject panel;
    public TextMeshProUGUI texto;

    public int[,] casillas;

    int jugador = 1;

    int contador = 0;

    void Start()
    {
        casillas = new int[3, 3];

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Instantiate(casilla, transform).GetComponent<CasillaUI>().iniciar(i, j, this);
                casillas[i, j] = 0;
            }
        }
    }

    public void reiniciar()
    {
        panel.SetActive(false);
        contador = 0;

        foreach(Transform t in transform)
        {
            t.gameObject.GetComponent<CasillaUI>().reiniciar();
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                casillas[i, j] = 0;
            }
        }
    }

    public void ganar(string mensaje)
    {
        panel.SetActive(true);
        texto.text = mensaje; 
    }

    public bool comprobar()
    {
        bool diag1 = true, diag2 = true;
        for (int i = 0; i < 3; i++)
        {
            bool fila = true, columna = true;
            for (int j = 0; j < 3; j++)
            {
                fila = fila && casillas[i, j] == jugador;
                columna = columna && casillas[j, i] == jugador;
            }

            if(fila || columna)
            {
                ganar("Gana el jugador: " + jugador); return true;
            }

            diag1 = diag1 && casillas[i, i] == jugador;
            diag2 = diag2 && casillas[i, 2 - i] == jugador;
        }

        if(diag1 || diag2)
        {
            ganar("Gana el jugador: " + jugador); return true;
        }

        return false;
    }

    public Sprite colocar(int i, int j)
    {
        contador++;
        casillas[i, j] = jugador;
        if(!comprobar() && contador == 9)
        {
            ganar("Empate");
        }

        if (jugador == 1)
        {
            jugador = 2;            
            return cruz;
        }
        else
        {
            jugador = 1;
            return circulo;
        }
    }
}
