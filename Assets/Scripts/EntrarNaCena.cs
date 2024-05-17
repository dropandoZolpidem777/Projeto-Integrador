using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EntrarNaCena : MonoBehaviour
{
    int desativarScript = 0; // 0 desativado 1 ativado

    PlayerCamera cam;
    public static int entrou; //0 = nao enterou, 1 = entrou na torre, 2 = 
    public GameObject inconePararecer;// Icone De Entra na torre

    public GameObject ObjetoAAparecer;//Dentro Da Torre
    public GameObject ObjectADesarecer;//MapaTorre


    void Start()
    {
        Camera.main.GetComponent<PlayerCamera>().enabled = false;
        //Ativar o script da Camera
        
        cam = GetComponent<PlayerCamera>();
        //pegando o componente PlayerCamera(script)
        inconePararecer.SetActive(false);
        //icone desativado
        entrou = 0;
    }

    public void TrocarDeCena()
    {
        desativarScript = 1;
        if (entrou == 1)
        {
            entrou = 2;
            inconePararecer.SetActive(false);
            //icone desativado
            ObjetoAAparecer.SetActive(true);
            ObjectADesarecer.SetActive(false);
            Camera.main.GetComponent<PlayerCamera>().enabled = true;
            //Ativar o script da Camera
        }
        if (entrou == 0) 
        {
            ObjetoAAparecer.SetActive(false);
        }
        if (entrou == 2)
        {
            inconePararecer.SetActive(false);
            ObjetoAAparecer.SetActive(true);
            ObjectADesarecer.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        entrou = 1;
        if (collision.CompareTag("Player"))
        {
            inconePararecer.SetActive(true);
        }
    }//Ativa o icone de intera��o no objeto

    private void OnTriggerExit2D(Collider2D collision)
    {
        entrou = 0;
        inconePararecer.SetActive(false);
    }//Desativa o icone de intera��o no objeto
}