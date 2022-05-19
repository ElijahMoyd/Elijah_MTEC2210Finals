using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] SpawnPoints;
    public GameObject enemyPrefab;
    public GameObject regenemyPrefab;
    public GameObject fastenemyPrefab;
    void Start()
    {
        InvokeRepeating("SpawnPoint", 3, 2);
    }


    void SpawnPoint()
    {

        int index = Random.Range(0, SpawnPoints.Length);
        Vector3 spawnPos = SpawnPoints[index].position;
        GameObject ship = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        GameObject ship2 = Instantiate(regenemyPrefab, spawnPos, Quaternion.identity);
        GameObject ship3 = Instantiate(fastenemyPrefab, spawnPos, Quaternion.identity);

        int dirModifer = -0;

        if (index > 2)
        {
            dirModifer = -1;
        }
        else
        {
            dirModifer = 1;
        }
    }
    }
  

