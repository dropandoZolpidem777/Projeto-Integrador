using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
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


}