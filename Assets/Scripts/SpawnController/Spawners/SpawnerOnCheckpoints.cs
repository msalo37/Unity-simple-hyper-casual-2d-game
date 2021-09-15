using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOnCheckpoints : BaseSpawner
{
    [SerializeField] private Transform[] checkPoints;
    
    protected override Vector3 GetPosition()
    {
        return checkPoints[Random.Range(0, checkPoints.Length)].position;
    }
}
