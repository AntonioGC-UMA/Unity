using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocida;

    public Rigidbody2D rb;


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(velocida, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-velocida, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, velocida);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -velocida);
        }
    }
}
