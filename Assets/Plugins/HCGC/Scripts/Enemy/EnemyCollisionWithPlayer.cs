using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EnemyCollisionWithPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var t = other.transform;
            t.DOScale(new Vector3(0, 0, 0), 0.2f).OnComplete(delegate
            {
                t.DOKill();
                Destroy(t.gameObject);
            });
        }
    }
}
