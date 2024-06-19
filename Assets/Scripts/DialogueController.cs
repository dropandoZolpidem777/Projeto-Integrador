using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    // Vari�vel para controlar se o jogador est� dentro do alcance da placa
    public int jogadorPerto = 0;
    // Variavel aparecer o bot�o para interagir
    public GameObject botaoAparecer;
    // Tecla para interagir
    public KeyCode teclaDeInteracao = KeyCode.E;
    // sprite do npc
    public Sprite profile;
    // texto
    public string[] speechTxt;
    // nome que aparece com o dialogo
    public string actorName;
    //outro script
    private Dialogue dc;

    public GameObject DesaparecerAtaque1;
    public GameObject DesaparecerAtaque2;

    public bool iniciaLutaTowerFight = false;
    public GameObject geradorInimigo;


    private void Update()
    {

    }

    private void Start()
    {
        //chamando outro script pelo nome
        dc = GameObject.FindObjectOfType<Dialogue>();
        //se clicar E vai abrir o dialogo
        teclaDeInteracao = KeyCode.E;
    }

    public void AceionarODialogo()
    {
        if (jogadorPerto == 1)
        {

            // Exibir o di�logo
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    void interacao()
    {
        // Verificar se o jogador est� perto e pressionou a tecla de intera��o
        if (jogadorPerto == 1 && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o di�logo
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    // Este m�todo � chamado quando o jogador entra no collider da placa
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //DesaparecerAtaque1.SetActive(false);
        DesaparecerAtaque2.SetActive(false);
        //JogadorPerto True
        jogadorPerto = 1;
        botaoAparecer.SetActive(true);
    }

    // Este m�todo � chamado quando o jogador sai do collider da placa
    public void OnTriggerExit2D(Collider2D collision)
    {
        //DesaparecerAtaque1.SetActive(true);
        DesaparecerAtaque2.SetActive(true);
        //JogadorPerto False
        jogadorPerto = 0;
        botaoAparecer.SetActive(false);

        if(iniciaLutaTowerFight == true)
        {
            Debug.Log("Come�ou a luta!");
            geradorInimigo.SetActive(true);
        }

    }
}
