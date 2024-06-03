using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyIA : MonoBehaviour
{
    public float detectionRadius = 5f; // Raio de detec��o do jogador
    public float patrolSpeed = 2f;     // Velocidade de patrulha
    public float chaseSpeed = 5f;      // Velocidade de persegui��o
    public List<Transform> patrolPoints;   // Pontos de patrulha (pontos no mapa que o inimigo ir� seguir)
    
    private Transform player;           // Refer�ncia ao jogador
    private int currentPatrolPoint = 0; // �ndice do ponto de patrulha atual
    private bool isChasing = false;     // Indica se o inimigo est� perseguindo o jogador

   int vida = 1;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //criar lista
        patrolPoints = new List<Transform>();

        //procurar os pontos na cena aonde deve patrulhar
        Transform pp = GameObject.Find("PatrolPoints").transform;
        //loop para sempre q encontar os filhos(Pontos q deve patrulhar)

        for (int i = 0; i < pp.childCount; i++)
        {
            patrolPoints.Add(pp.GetChild(i));
        }        

    }

    void Update()
    {
        // Verifica se o jogador est� dentro do raio de detec��o
        if (Vector2.Distance(transform.position, player.position) <= detectionRadius)
        {
            // Come�a a perseguir o jogador
            isChasing = true;
        }
        else
        {
            // Se n�o estiver perseguindo, patrulha entre os pontos
            isChasing = false;
            Patrol();
        }

        // Se estiver perseguindo, move em dire��o ao jogador
        if (isChasing)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * chaseSpeed * Time.deltaTime);
        }
    }

    void Patrol()
    {
        // Move em dire��o ao ponto de patrulha atual
        Vector2 targetPoint = patrolPoints[currentPatrolPoint].position;
        transform.position = Vector2.MoveTowards(transform.position, targetPoint, patrolSpeed * Time.deltaTime);

        // Se alcan�ou o ponto de patrulha atual, passa para o pr�ximo ponto
        if (Vector2.Distance(transform.position, targetPoint) < 0.1f)
        {
            currentPatrolPoint = (currentPatrolPoint + 1) % patrolPoints.Count;
        }
    }

    void OnDrawGizmosSelected()
    {
        // Desenha um gizmo para visualizar o raio de detec��o na cena da Unity
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("sword") )
        {
            vida--;
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}





