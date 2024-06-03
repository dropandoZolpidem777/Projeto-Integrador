using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLadoALado : MonoBehaviour
{
    float velocidade = 10;
    public Transform direita;
    public Transform esquerda;

    public bool indoParaDireita = false;

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

        Vector3 movimento = Vector3.zero;


        if ( indoParaDireita == true)
        {
            movimento = Vector3.MoveTowards(transform.position, direita.position, velocidade * Time.deltaTime);
            if( Vector3.Distance(transform.position, direita.position) < 0.1f)
            {
                indoParaDireita = false;
            }
        }
        else
        {
            movimento = Vector3.MoveTowards(transform.position, esquerda.position, velocidade * Time.deltaTime);
            Debug.Log(Vector3.Distance(transform.position, esquerda.position));
            if (Vector3.Distance(transform.position, esquerda.position) < 0.1f)
            {
                indoParaDireita = true;
            }
        }

        transform.position = movimento;

        return;
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
