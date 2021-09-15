using System.Collections;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] protected float spawnDelay;
    
    [SerializeField] protected BaseSpawner _spawner;
    [SerializeField] protected IEndPoint _endPoint;

    [SerializeField] protected GameObject prefab;

    private void Awake()
    {
        // if x == null then ... --> x ??= ...
        _spawner ??= GetComponent<BaseSpawner>();
        _endPoint ??= GetComponent<IEndPoint>();
    }

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    protected virtual IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            GameObject box = _spawner.Create(prefab);
            
            if (_endPoint != null && box.TryGetComponent(out MovingObject movingObject))
                movingObject.SetEndPoint(_endPoint.GetPosition());
        }
    }
}
