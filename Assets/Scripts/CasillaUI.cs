using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasillaUI : MonoBehaviour
{

    public Button boton;

    int i, j;
    Controlador c;

    public void iniciar(int i, int j, Controlador c)
    {
        this.i = i;
        this.j = j;
        this.c = c;
    }

    public void reiniciar()
    {
        boton.image.sprite = null;
        boton.interactable = true;
    }


    public void click()
    {
        boton.interactable = false;

        boton.image.sprite = c.colocar(i, j);
    }
}
