using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;// Colocar imagem

public class TrocarDeImagemDaVida : MonoBehaviour
{
    public int vida = 5;
    public SpriteRenderer vidaSprite;
    //string primeiro = "Assets/Sprites/vida/barravidadividida_01";
    //string segundo = "Assets/Sprites/vida/barravidadividida_02";
    //string terceiro = "Assets/Sprites/vida/barravidadividida_03";
    //string quarto = "Assets/Sprites/vida/barravidadividida_04";
    //string quinto = "Assets/Sprites/vida/barravidadividida_05";
    public Sprite primeiro;
    public Sprite segundo;
    public Sprite terceiro;
    public Sprite quarto;
    public Sprite quinto;

    public bool podeApanhar = true;
    float tempoApanhar = 2;

    List<Sprite> spritesVidas = new List<Sprite>();

    private void Start()
    {
        spritesVidas.Add(primeiro);
        spritesVidas.Add(segundo);
        spritesVidas.Add (terceiro);
        spritesVidas.Add (quarto);
        spritesVidas.Add(quinto);
    }

    private void Update()
    {

        if (podeApanhar == false)
        {
            tempoApanhar -= Time.deltaTime;
            if (tempoApanhar < 0)
            {
                podeApanhar = true;
                tempoApanhar = 2;
            }
        }

        if (vida == 4)
        {
            
            
            vidaSprite.sprite = segundo;

        }
        if (vida == 3)
        {
           
          
            vidaSprite.sprite = terceiro;
        }
        if (vida == 2)
        {
            
           
            vidaSprite.sprite = quarto;
        }
        if (vida == 1)
        {
            
            
            vidaSprite.sprite = quinto;
        }

        if(vida <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

    }

    public void TrocarAImagem()
    {
        


    }

    public void MortePlayer()
    {
        vida--;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("enemy"))
    //    {
    //        vida--;
    //        if (vida <= 0)
    //        {
    //            Destroy(gameObject);
    //        }
    //    }
    //}
}