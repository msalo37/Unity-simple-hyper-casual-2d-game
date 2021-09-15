using UnityEngine;

public class EndPoint : MonoBehaviour, IEndPoint
{
    [SerializeField] private Transform endPoint;
    
    public Vector3 GetPosition()
    {
        return endPoint.position;
    }
}
