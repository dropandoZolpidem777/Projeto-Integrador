using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BossEscudo : MonoBehaviour
{
    public int hits;
    public int ativouEscudo = 0;

    public float tempoDeDesativacaoAutomatica = 0;

    public Transform prefabDoEscudo;
    public Transform spawnDoEscudo;

    Transform escudoAtivo;


    // Start is called before the first frame update
    void Start()
    {
        tempoDeDesativacaoAutomatica = UnityEngine.Random.Range(10, 20);
    }

    void Update()
    {
        if (BossVida.vidaAtualDoBoss == 5 && ativouEscudo == 0)
        {
            AtivarEscudo();
            ativouEscudo = 1;
        }
        if (ativouEscudo == 1)
        {
            CotadorAleatorio();
            tempoDeDesativacaoAutomatica -= Time.deltaTime;
            if (tempoDeDesativacaoAutomatica <= 0)
            {   
                QuebrarEscudo();
                ativouEscudo = 0;
            }
        }
    }

    public void AtivarEscudo()
    {
        GetComponent<CapsuleCollider2D>().enabled = false;
        GetComponent<BossLadoALado>().enabled = false;
        escudoAtivo = Instantiate(prefabDoEscudo, transform.position, transform.rotation);
        hits = UnityEngine.Random.Range(3, 5);
    }

    void CotadorAleatorio()
    {
        if(tempoDeDesativacaoAutomatica <= 0)
        {
            tempoDeDesativacaoAutomatica = UnityEngine.Random.Range(10, 20);
        }
    }

    public void QuebrarEscudo()
    {
        GetComponent<BossLadoALado>().enabled = true;
        GetComponent<CapsuleCollider2D>().enabled = true;
        Destroy(escudoAtivo.gameObject);
    }

    public void Escudo()
    {
        hits--;
        if (hits <= 0)
        {
            QuebrarEscudo();
        }
    }

}