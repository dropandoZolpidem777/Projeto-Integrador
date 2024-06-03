using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public static int vida = 5;
    public int vidaVista;

    private void Start()
    {
        AparecerVidaAtaual();
    }

    private void Update()
    {
        AparecerVidaAtaual();
        MortePlayer();
    }


    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void MortePlayer()
    {
        // vida--;
        if ( vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    void AparecerVidaAtaual()
    {
        vidaVista = vida;
    }

}
