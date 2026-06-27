using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnTime = 5.0f;
    [SerializeField] float minSpawnTime = 3.0f;
    [SerializeField] float spawnTimeDecrease = 3.0f;
    [SerializeField] GameObject enemyPrefab;

    float currentSpawnTime;

    void Start()
    {
        currentSpawnTime = spawnTime;
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(currentSpawnTime);
            currentSpawnTime = Mathf.Max(minSpawnTime, currentSpawnTime - spawnTimeDecrease);
        }
    }
}
