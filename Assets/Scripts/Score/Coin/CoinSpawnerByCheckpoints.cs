using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerByCheckpoints : MonoBehaviour, ISpawner
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private Transform[] checkPoints;
    
    public GameObject Create()
    {
        return Instantiate(coinPrefab, checkPoints[Random.Range(0, checkPoints.Length)].position, Quaternion.identity);
    }
}
