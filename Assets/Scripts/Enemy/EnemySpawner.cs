using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private float enemyLifetime;

    [SerializeField] private Transform[] endCheckpoints;

    private ISpawner _spawner;

    private void Start()
    {
        _spawner = GetComponent<ISpawner>();
        StartCoroutine(StartEnemySpawner());
    }

    private IEnumerator StartEnemySpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Enemy enemy = _spawner.Create().GetComponent<Enemy>();
            enemy.SetPoint(endCheckpoints[Random.Range(0, endCheckpoints.Length)].position);
        }
    }
}
