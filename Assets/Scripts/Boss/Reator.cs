using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reator : MonoBehaviour
{
    public GameObject prefabEscudo;

    BossEscudo escudoBoss;

    public int destruir;
    public int contagem;

    private void Start()
    {
        escudoBoss = GetComponent<BossEscudo>();
        destruir = UnityEngine.Random.Range(1, 3);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        contagem++;
        if (c.CompareTag("Player") && contagem == destruir)
        {

            c.GetComponent<BossEscudo>().QuebrarEscudo();
        }
    }
}

