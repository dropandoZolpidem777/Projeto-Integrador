using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Dash : MonoBehaviour
{
    
    Vector2 direcaoX;
    Vector2 direcaoY;
    public float velocidadeDash = 25f;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcaoX = new Vector2(transform.position.x, transform.position.y);
        Vector2 direcaoY = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        //Tecla Shift + W
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            direcaoX = Vector2.up * velocidadeDash * Time.deltaTime;
        }
        //Tecla Shift + S
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            transform.position = Vector2.down * velocidadeDash * Time.deltaTime;
        }
        //Tecla Shift + A
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            transform.position = Vector2.left * velocidadeDash * Time.deltaTime;
        }
        //Tecla Shift + D
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            transform.position = Vector2.right * velocidadeDash * Time.deltaTime;
        }

    }
}
