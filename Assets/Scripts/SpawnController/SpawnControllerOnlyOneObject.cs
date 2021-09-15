using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControllerOnlyOneObject : SpawnController
{
    private GameObject lastObject;
    
    protected override IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);

            if (lastObject != null)
                continue;
            
            lastObject = _spawner.Create(prefab);

            if (_endPoint != null && lastObject.TryGetComponent(out MovingObject movingObject))
                movingObject.SetEndPoint(_endPoint.GetPosition());
        }
    }
}
