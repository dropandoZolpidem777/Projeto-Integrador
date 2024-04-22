using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGerator : MonoBehaviour
{
    public GameObject enemyPrefab;      // Prefab do inimigo a ser gerado
    public float spawnInterval = 2f;    // Intervalo de tempo entre os spawns
    public float spawnRadius = 5f;      // Raio de spawn ao redor do gerador
    public float spawnDuration = 60f;   // Duração de spawn em segundos (1 minuto)

    private float spawnTimer = 0f;
    private float spawnTimeElapsed = 0f;

    void Update()
    {
        if (spawnTimeElapsed < spawnDuration)
        {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnInterval)
            {
                SpawnEnemy();
                spawnTimer = 0f;
            }

            spawnTimeElapsed += Time.deltaTime;
        }
    }

    void SpawnEnemy()
    {
        // Calcula uma posição aleatória dentro do spawnRadius
        Vector2 randomDirection = Random.insideUnitCircle.normalized * spawnRadius;
        Vector3 spawnPosition = new Vector3(transform.position.x + randomDirection.x, transform.position.y + randomDirection.y, 0f);

        // Instancia o inimigo na posição aleatória
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Obtém o componente EnemyAI do inimigo gerado (assumindo que o inimigo tem o script EnemyAI anexado)
        EnemyIA enemyIA = newEnemy.GetComponent<EnemyIA>();

        // Se o componente EnemyAI for encontrado, define o inimigo para patrulhar
        if (enemyIA != null)
        {
           // enemyIA.patrol(); // Método fictício para definir o inimigo para patrulhar
        }
    }
}

