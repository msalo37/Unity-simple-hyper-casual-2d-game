using DG.Tweening;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private Vector3 endPos = Vector3.zero;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos, moveSpeed * Time.deltaTime);

        if (endPos == transform.position)
            DestroyMe();
    }

    public void SetEndPoint(Vector3 vec3)
    {
        endPos = vec3;
    }

    private void DestroyMe()
    {
        transform.DOScale(new Vector3(0, 0, 0), 0.2f).OnComplete(delegate
        {
            transform.DOKill(); // need to avoid errors
            Destroy(gameObject);
        });
    }
    
}
