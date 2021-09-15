using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBeyondTwoPoints : BaseSpawner
{
    [SerializeField] private Transform firstPoint, secondPoint;

    protected override Vector3 GetPosition()
    {
        return RandomVector(firstPoint.position, secondPoint.position);
    }

    private Vector3 RandomVector(Vector3 min, Vector3 max)
    {
        return new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
    }
}
