using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reator : MonoBehaviour
{
    BossEscudo escudoBoss;

    int destruir;
    public static int contagem;

    private void Start()
    { 
        destruir = 3;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (contagem == destruir)
        {
            BossEscudo.instacia.QuebrarEscudo();
            contagem = 0;
        }
    }
}