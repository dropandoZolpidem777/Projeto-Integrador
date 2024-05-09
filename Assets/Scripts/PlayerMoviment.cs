using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    public int vida = 5;

    //Detectar o JoyStick
    public FixedJoystick moveJoystick;
    // velocidade que o personage que vai andar
    float velocidadeAndar = 5f;




    void Update()
    {
        //Chamar toda hora a funcao movimentacao
        Movimentação();
    }

    void Movimentação()
    {
        float horizontal = moveJoystick.Horizontal;
        float vertical = moveJoystick.Vertical;

        Vector2 movimentacao = new Vector2(horizontal, vertical);
        transform.Translate(movimentacao * velocidadeAndar * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            vida--;
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}