using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [Range(5,10)]
    public int spawnRange = 6; //Time between each spawn

    public List<GameObject> obstacles = new List<GameObject>(); //List of obstacles
    
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnRange);
    }

    void SpawnObstacle()
    {
        Vector2 spawnPosition = new Vector2();
        spawnPosition.x = transform.position.x;
        spawnPosition.y = Random.Range(-2, 0.5f);   //Between which values it can spawn

        int listSize = obstacles.Count;
        int random = Random.Range(0, listSize);     //Picks a random obstacle to spawn

        Instantiate(obstacles[random], spawnPosition, Quaternion.identity);
    }
    
}
