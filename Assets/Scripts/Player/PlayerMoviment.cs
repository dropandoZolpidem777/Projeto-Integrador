using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    // Detectar o JoyStick
    public VariableJoystick moveJoystick;
    // velocidade que o personagem vai andar
    public float velocidadeAndar = 5f;

    // Referência ao Rigidbody2D do jogador
    private Rigidbody2D rb;

    void Start()
    {
        // Inicializar a referência ao Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Chamar toda hora a função movimentação
        Movimentacao();
    }

    void Movimentacao()
    {

        float horizontal = moveJoystick.Horizontal;
        float vertical = moveJoystick.Vertical;

        Vector2 movimentacao = new Vector2(horizontal, vertical);
       
        // Movimentar o jogador usando o Rigidbody2D
        rb.velocity = movimentacao * velocidadeAndar;



    }
}