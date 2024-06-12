using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefesa : MonoBehaviour
{
    public int hits;
    public Transform prefabEscudo;
    public float tempoDeDestruicaoDoEscudo = 4f;
    public float tempoDeVoltarAAtivarOEscudo = 8f;
    public Transform escudo;
    public int escudoAtivo = 0;
    public int inicarContagem = 0;
     GameObject p;

    private void Start()
    {
        p = GameObject.Find("Player");
    }

    private void Update()
    {
        if (inicarContagem == 1)
        {
            tempoDeDestruicaoDoEscudo -= Time.deltaTime;
        }
        if (escudoAtivo == 1) 
        {
            if (tempoDeDestruicaoDoEscudo <= 0)
            {
                DestruirEscudo();
            }
            
        }
        if(hits <= 0)
        {
            DestruirEscudo();
            p.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(escudo.gameObject);
        }
    }

    public void AtivarEscudo()
    {
        inicarContagem = 1;
        escudoAtivo = 1;
        p.GetComponent<BoxCollider2D>().enabled = false;
        escudo = Instantiate(prefabEscudo, transform.position, transform.rotation);
        escudo.transform.parent = p.transform;
        hits = UnityEngine.Random.Range(2, 4);
    }

    void DestruirEscudo()
    {
        inicarContagem = 0;
        escudoAtivo = 0;
        p.GetComponent<BoxCollider2D>().enabled = true;
        Destroy(escudo.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Bala"))
        {
            hits--;
        }
    }

}
