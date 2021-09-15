using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotationVector;
    [SerializeField] private float speed = 5f;
    
    private void Update()
    {
        transform.Rotate(rotationVector * speed * Time.deltaTime);
    }
}
