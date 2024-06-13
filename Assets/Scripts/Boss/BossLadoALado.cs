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
    public float tempodeDeFicarParado;
    public float tempoAndando;

    public int direcao = 0; // 1- Esquerda 2- Direita
    // Start is called before the first frame update
    void Start()
    {
        tempoDeMudarDeLado = UnityEngine.Random.Range(2,4);
        tempodeDeFicarParado = UnityEngine.Random.Range(2,4);
        tempoAndando = UnityEngine.Random.Range(4,6);
    }

    // Update is called once per frame
    void Update()
    {
        if (tempodeDeFicarParado >= tempodeDeFicarParado)
        {
            //GetComponent<BossAtaqueSpawn>().enabled = false;
        }
        //Vector3 movimento = Vector3.zero;
        Vector3 movimento = new Vector3(13.9f, -15.23f, 0);
        tempodeDeFicarParado -= Time.deltaTime;
        if (tempodeDeFicarParado <= 0)
        {
            //GetComponent<BossAtaqueSpawn>().enabled = true;
            tempoAndando -= Time.deltaTime;
            if(tempoAndando <= 0)
            {
                
                tempoAndando = UnityEngine.Random.Range(3, 6);
                tempodeDeFicarParado = UnityEngine.Random.Range(3, 6);
            }

            if (indoParaDireita == true)
            {
                movimento = Vector3.MoveTowards(transform.position, direita.position, velocidade * Time.deltaTime);
                if (Vector3.Distance(transform.position, direita.position) < 0.1f)
                {
                    indoParaDireita = false;
                }
            }
            else
            {
                movimento = Vector3.MoveTowards(transform.position, esquerda.position, velocidade * Time.deltaTime);
                if (Vector3.Distance(transform.position, esquerda.position) < 0.1f)
                {
                    indoParaDireita = true;
                }
            }
        }
        

        transform.position = movimento;

     
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
