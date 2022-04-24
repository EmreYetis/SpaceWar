using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
      
    public int waweNumber = 1;
    public int enemyCount;
    
    void Start()
    {
        SpawnEnemyWawe(waweNumber);
    } 
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount == 0)
        {
            waweNumber++;
            SpawnEnemyWawe(waweNumber);
        }
        
    }

    void SpawnEnemyWawe(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
        }
    }

    private Vector2 GenerateSpawnPosition()
    {
        float spawnRangeX = Random.Range(24f, 32f);
        float spawnRangeY = Random.Range(-9.8f, 9.8f);

        Vector2 randomPos = new Vector2(spawnRangeX,spawnRangeY);

        return randomPos;
    }
}
