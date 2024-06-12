using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVida : MonoBehaviour
{
    int vidaMaximaDoBoss = 10;
    public static int vidaAtualDoBoss;

    private void Update()
    {
        vidaAtualDoBoss = vidaMaximaDoBoss;
    }


    void MorteBoss()
    {
        vidaAtualDoBoss--;
        if (vidaAtualDoBoss <= 0)
        {
            Destroy(gameObject);
        }
    }
}