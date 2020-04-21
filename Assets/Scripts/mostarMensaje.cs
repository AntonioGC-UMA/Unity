using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostarMensaje : MonoBehaviour
{
    public GameObject mensaje;


    void OnTriggerEnter2D(Collider2D col)
    {
        mensaje.SetActive(true);
        Destroy(gameObject);
    }
}
