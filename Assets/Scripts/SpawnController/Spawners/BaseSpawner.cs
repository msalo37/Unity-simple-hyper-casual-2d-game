using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    public virtual GameObject Create(GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, GetPosition(), Quaternion.identity);
        return obj;
    }

    protected abstract Vector3 GetPosition();
}
