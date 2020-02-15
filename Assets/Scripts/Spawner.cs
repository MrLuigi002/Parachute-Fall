using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacleOne;
    public GameObject obstacleTwo;
    public GameObject obstacleThree;

    [Range(5,10)]
    public int spawnRange = 6;

    //public float randomRange = 2.5f;
    
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, spawnRange);
    }

    void SpawnObstacle()
    {
        Vector2 spawnPosition = new Vector2();
        spawnPosition.x = transform.position.x;
        spawnPosition.y = Random.Range(-2, 1);

        Instantiate(obstacleOne, spawnPosition, Quaternion.identity);
    }
    
}
