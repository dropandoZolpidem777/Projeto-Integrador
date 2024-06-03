using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLadoALado : MonoBehaviour
{
    float velocidade = 10;
    public Transform direita;
    public Transform esquerda;

    public float tempoDeMudarDeLado;

    public int direcao = 0; // 1- Esquerda 2- Direita
    // Start is called before the first frame update
    void Start()
    {
        tempoDeMudarDeLado = UnityEngine.Random.Range(2,4);
    }

    // Update is called once per frame
    void Update()
    {
        tempoDeMudarDeLado -= Time.deltaTime;
        if(tempoDeMudarDeLado <= 0)
        {
            direcao = UnityEngine.Random.Range(1,2);
        }
        Direita();
        if (direcao == 1)//Esquerda
        {
            direcao = 2;
            Esquerda();
        }
        if (direcao == 2)//Direita
        {
            direcao = 1;
            Direita();
        }
    }

    void Direita()
    {
        Vector3 movimento = Vector3.MoveTowards(transform.position, direita.position, velocidade * Time.deltaTime);
        transform.position = movimento;
    }

    void Esquerda()
    {
        Vector3 movimento = Vector3.MoveTowards(transform.position, esquerda.position, velocidade * Time.deltaTime);
        transform.position = movimento;
    }

}
