using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointBeyondTwoPoints : MonoBehaviour, IEndPoint
{
    private Vector3 RandomVector(Vector3 min, Vector3 max)
    {
        return new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
    }

    [SerializeField] private Transform firstPoint, secondPoint;

    public Vector3 GetPosition()
    {
        return RandomVector(firstPoint.position, secondPoint.position);
    }
}
