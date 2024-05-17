using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
 

    public Transform player;
    // Referência ao transform do jogador
    float suavidadeMovimento = 10f;

    // Velocidade suave de movimento da câmera

    public Vector3 deslocamento;
    // Deslocamento da câmera em relação ao jogador

    void Update()
    {
        Vector3 posicaoDesejada = player.position + deslocamento;
        Vector3 posicaoSuavizada = Vector3.Lerp(transform.position, posicaoDesejada, suavidadeMovimento);
        transform.position = new Vector3(posicaoSuavizada.x, posicaoSuavizada.y, transform.position.z); // Mantém a câmera na mesma profundidade (z) em relação ao mundo
    }
    
}
