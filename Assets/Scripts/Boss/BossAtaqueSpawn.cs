using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossAtaqueSpawn : MonoBehaviour
{
    //Tempo para spawnar
    public int tempoDeSpawn = 0;
    //TempoAtual de poder atacar de novo
    public float tempoAtualDoAtaque;
    //Tempo de morte da bala
    public float tempoMorteBala;

    //Prefab da bala
    public Transform prefabAtaque;
    //Local aonde vai spawnar a bala
    public Transform spawnAtaque;

    //int numeroDeEspera = Random

    // Start is called before the first frame update
    void Start()
    {
        //vai gerar um valor random para spawnar os ataques
        tempoDeSpawn = UnityEngine.Random.Range(3, 5);
        //vai gerar um valor random para a bala ser distroida
        tempoMorteBala = UnityEngine.Random.Range(6, 9);

        tempoAtualDoAtaque = tempoDeSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        // vai fazer o tempo para poder atacar cair como o tempo real
        
        tempoAtualDoAtaque -= Time.deltaTime;
        //tempoAtualDoAtaque = tempoAtualDoAtaque - Time.deltaTime;

        //se tempo de ataque chegar a zero ele vai poder atacar mais um vez
        if (tempoAtualDoAtaque <= 0)
        {
            SpawnarAtack();
            ContagemDeSpawnBala();
        }

    }

    //função que vai spawnar o ataque e destroir ele depois de um tempo
    void SpawnarAtack()
    {
        Transform ataque = Instantiate(prefabAtaque);
        //Transform ataque = Instantiate(prefabAtaque, spawnAtaque.position, spawnAtaque.rotation);
        Destroy(ataque.gameObject, tempoMorteBala);
    }

    //vai gerar um tempo de spawn aleatorio entre 3 e 5
    void ContagemDeSpawnBala()
    {
        tempoDeSpawn = UnityEngine.Random.Range(3, 5);
        tempoAtualDoAtaque = tempoDeSpawn;
    }
}
