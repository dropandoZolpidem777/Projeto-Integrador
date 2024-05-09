using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public GameObject gerador;
    // Variável para controlar se o jogador está dentro do alcance da placa
    public int jogadorPerto = 0;
    // Variavel aparecer o botão para interagir
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

    private void Start()
    {
        //chamando outro script pelo nome
        dc = GameObject.FindObjectOfType<Dialogue>();
        //se clicar E vai abrir o dialogo
        teclaDeInteracao = KeyCode.E;
        botaoAparecer.SetActive(false);
        gerador.SetActive(false);
    }

    public void AceionarODialogo()
    {
        if (jogadorPerto == 1)
        {
            // Exibir o diálogo
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    void interacao()
    {
        // Verificar se o jogador está perto e pressionou a tecla de interação
        if (jogadorPerto == 1 && Input.GetKeyDown(teclaDeInteracao))
        {
            // Exibir o diálogo
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    // Este método é chamado quando o jogador entra no collider da placa
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //destivar o gerador
        gerador.SetActive(false);
        //JogadorPerto True
        jogadorPerto = 1;
        botaoAparecer.SetActive(true);
    }

    // Este método é chamado quando o jogador sai do collider da placa
    public void OnTriggerExit2D(Collider2D collision)
    {
        //ativar o gerador
        gerador.SetActive(true);
        //JogadorPerto False
        jogadorPerto = 0;
        botaoAparecer.SetActive(false);
    }
}
