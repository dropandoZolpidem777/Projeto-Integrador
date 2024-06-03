using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVida : MonoBehaviour
{
    int bossVida = 10;

    void MorteBoss()
    {
        bossVida--;
        if (bossVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
