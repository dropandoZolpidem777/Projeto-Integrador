using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefesa : MonoBehaviour
{
    public int hits;
    public Transform prefabEscudo;
    public float tempoDeDestruicaoDoEscudo = 1f;
    public float tempoDeVoltarAAtivarOEscudo = 8f;
    public Transform escudo;
    int escudoAtivo = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (escudoAtivo == 1) 
        {
            tempoDeDestruicaoDoEscudo -= Time.deltaTime;
            if (tempoDeDestruicaoDoEscudo <= 0)
            {
                DestruirEscudo();
            }
        }
        if(hits <= 0)
        {
            DestruirEscudo();
            GetComponent<CapsuleCollider2D>().enabled = true;
            Destroy(escudo.gameObject);
        }
    }

    public void AtivarEscudo()
    {
        escudoAtivo = 1;
        GetComponent<CapsuleCollider2D>().enabled = false;
        escudo = Instantiate(prefabEscudo, transform.position, transform.rotation);
        hits = UnityEngine.Random.Range(2, 4);
    }

    void DestruirEscudo()
    {
        escudoAtivo = 0;
        GetComponent<CapsuleCollider2D>().enabled = true;
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
