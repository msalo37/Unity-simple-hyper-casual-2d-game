using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using DG.Tweening;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float rotationSpeed, moveSpeed;

    private Vector3 endPos;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos, moveSpeed * Time.deltaTime);
        
        transform.Rotate(new Vector3(0,0, rotationSpeed * Time.deltaTime));
        
        if (endPos == transform.position)
            DestroyMe();
    }

    public void SetPoint(Vector3 vec3)
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
