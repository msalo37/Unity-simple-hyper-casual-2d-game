using UnityEngine;
public class SpawnerAroundObject : BaseSpawner
{
    [SerializeField] private GameObject centerObject;
    [SerializeField] private float radius = 1f;

    protected override Vector3 GetPosition()
    {
        float angle = Random.Range(0, 360) * Mathf.PI * 2f / 8;
        Vector3 pos = new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 1);
        return pos;
    }
}
