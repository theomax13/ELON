using System.Collections;
using UnityEngine;

public class EnnemiSpawner : MonoBehaviour
{
    [SerializeField] GameObject ennemiPrefab;
    private float spawnY = 7f;
    private float minSpawnX = -7f;
    private float maxSpawnX = 7f;
    private float spawnX;
    private Vector2 spawnPosition;

    private float minSpawnDelay = 1.5f;
    private float maxSpawnDelay = 3f;
    private float spawnDelay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnnemiAtRandomInterval());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEnnemi()
    {
        spawnX = Random.Range(minSpawnX, maxSpawnX);
        spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(ennemiPrefab, spawnPosition, Quaternion.identity);
        StartCoroutine(SpawnEnnemiAtRandomInterval());
    }

    IEnumerator SpawnEnnemiAtRandomInterval()
    {
        spawnDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
        yield return new WaitForSeconds(spawnDelay);
        spawnEnnemi();
    }
}
