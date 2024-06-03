using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AtaqueSeguePlayer : MonoBehaviour
{
    public float velocidade = 2f;
    public Vector3 posicaoAntigaPlayer;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        posicaoAntigaPlayer = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SeguirPlayer();
    }

    void SeguirPlayer()
    {
        Vector3 movimento = Vector3.MoveTowards(transform.position, posicaoAntigaPlayer, velocidade * Time.deltaTime);
        //Vector3 movimento = player.position * velocidade * Time.deltaTime;
        transform.position = movimento;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            VidaPlayer.vida--;
            Destroy(gameObject);
        }
    }
}
