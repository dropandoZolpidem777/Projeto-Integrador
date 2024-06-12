using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoSeguirBoss : MonoBehaviour
{
    Transform bossPosicao;
    float velocidade = 5f;

    private void Start()
    {
        bossPosicao = GameObject.Find("Boss").GetComponent<Transform>();
    }

    void Update()
    {
        SeguirPlayer();
    }

    void SeguirPlayer()
    {
        Vector3 movimento = Vector3.MoveTowards(transform.position, bossPosicao.transform.position, velocidade * Time.deltaTime);
        //Vector3 movimento = player.position * velocidade * Time.deltaTime;
        transform.position = movimento;
    }
}
