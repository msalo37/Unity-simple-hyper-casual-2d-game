using UnityEngine;
public class SpawnerAroundObject : MonoBehaviour, ISpawner
{
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private GameObject centerObject;

    [SerializeField] private float radius;
    
    public Enemy CreateEnemy()
    {
        float angle = Random.Range(0, 360) * Mathf.PI * 2f / 8;
        Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 1);
        GameObject go = Instantiate(enemyPrefab, newPos, Quaternion.identity);
        return go.GetComponent<Enemy>();
    }
}
