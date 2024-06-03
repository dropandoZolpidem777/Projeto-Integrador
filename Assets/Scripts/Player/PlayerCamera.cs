using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
 

    public Transform player;
    // Refer�ncia ao transform do jogador
    float suavidadeMovimento = 10f;

    // Velocidade suave de movimento da c�mera

    public Vector3 deslocamento;
    // Deslocamento da c�mera em rela��o ao jogador

    void Update()
    {
        Vector3 posicaoDesejada = player.position + deslocamento;
        Vector3 posicaoSuavizada = Vector3.Lerp(transform.position, posicaoDesejada, suavidadeMovimento);
        transform.position = new Vector3(posicaoSuavizada.x, posicaoSuavizada.y, transform.position.z); // Mant�m a c�mera na mesma profundidade (z) em rela��o ao mundo
    }
    
}
