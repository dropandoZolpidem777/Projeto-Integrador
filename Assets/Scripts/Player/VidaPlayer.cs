using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Colocar imagem

public class VidaPlayer : MonoBehaviour
{
    public static int vida = 5;
    public int vidaAtual;

    public Image imagemDaCidade;
    string CaminhoParaTrocarAVida = "";


    private void Start()
    {
        vidaAtual = vida;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    public void MortePlayer()
    {
        vidaAtual--;
        TrocarDeImagem();
        if (vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
    }

    void TrocarDeImagem()
    {
        
        if (vidaAtual == 4)
        {
            CaminhoParaTrocarAVida = "Sprites/vida/barravidadividida_02";
            Sprite sprite = Resources.Load<Sprite>(CaminhoParaTrocarAVida);
            imagemDaCidade.sprite = sprite;
        }
        if (vidaAtual == 3)
        {
            CaminhoParaTrocarAVida = "Sprites/vida/barravidadividida_03";
            Sprite sprite = Resources.Load<Sprite>(CaminhoParaTrocarAVida);
            imagemDaCidade.sprite = sprite;
        }
        if (vidaAtual == 2)
        {
            CaminhoParaTrocarAVida = "Sprites/vida/barravidadividida_04";
            Sprite sprite = Resources.Load<Sprite>(CaminhoParaTrocarAVida);
            imagemDaCidade.sprite = sprite;
        }
        if (vidaAtual == 1)
        {
            CaminhoParaTrocarAVida = "Sprites/vida/barravidadividida_05";
            Sprite sprite = Resources.Load<Sprite>(CaminhoParaTrocarAVida);
            imagemDaCidade.sprite = sprite;
        }
    }
}
